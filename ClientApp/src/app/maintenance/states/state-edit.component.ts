import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
//import { HttpClient, HttpParams } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { State } from './state';
import { StateService } from './states.service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ApiResult } from '../../base.service';
import { BaseFormComponent } from '../../base.form.component'

@Component({
  selector: 'app-state-edit',
  templateUrl: './state-edit.component.html',
  styleUrls: ['./state-edit.component.css']
})
export class StateEditComponent extends BaseFormComponent implements OnInit {
  title: string;
  form: FormGroup;
  state: State;
  stateCode?: string;
  stateId?: number;

  constructor(private activatedRoute: ActivatedRoute,
    private router: Router,
    private stateService: StateService,
    @Inject('BASE_URL') private baseUrl: string) { super(); }

  ngOnInit() {
    this.form = new FormGroup({
      stateName: new FormControl('', Validators.required),
      stateCode: new FormControl('', [Validators.required, Validators.maxLength(2)]),
    }, null, this.isDuplicate());
    this.loadData();
  }

  loadData() {
    this.stateCode = this.activatedRoute.snapshot.paramMap.get("stateCode");

    if (this.stateCode) {
      //EDIT MODE - State uses the Code as the Primary Key/Unique identifer
      this.stateService.get<State>(this.stateCode)
        .subscribe(result => {
          this.state = result;
          this.title = "Edit " + this.state.stateName;
          this.stateCode = this.state.stateCode;
          this.stateId = this.state.stateId;

          this.form.patchValue(this.state);
        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = 'Create a new State';
    }
  }

  isDuplicate(): AsyncValidatorFn {
    return (control: AbstractControl): Observable<{ [key: string]: any } | null> => {
      var state = <State>{};
      state.stateId = (this.stateId) ? this.stateId : 0;
      //state.stateCode = (this.stateCode) ? this.stateCode : null;
      state.stateCode = this.form.get("stateCode").value;
      state.stateName = this.form.get("stateName").value;

      return this.stateService.isDuplicate(state)
        .pipe(map(result => {
          return (result ? { isDuplicate: true } : null);
        }));
    }
  }

  onSubmit() {
    var state = (this.stateCode) ? this.state : <State>{};

    state.stateName = this.form.get("stateName").value;
    state.stateCode = this.form.get("stateCode").value;
    state.stateId = this.stateId;

    if (this.stateCode) {
      //EDIT MODE
      this.stateService.put<State>(this.state)
        .subscribe(result => {
          console.log("State " + state.stateCode + " has been updated.");
          this.router.navigate(['/states']);
        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.stateService.post<State>(state)
        .subscribe(result => {
          console.log("State " + result.stateCode + " has been created.");
          this.router.navigate(['/states']);
        }, error => console.error(error));
    }
  }

  onDelete() {
    var state = (this.stateCode) ? this.state : <State>{};
    this.stateService.delete<State>(state.stateCode)
      .subscribe(result => {
        console.log("State " + state.stateCode + " has been deleted.");
        this.router.navigate(['/states']);
      }, error => console.error(error));
  }

}
