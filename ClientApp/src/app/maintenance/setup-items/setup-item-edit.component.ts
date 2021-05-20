import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

import { SetupItem } from './setup-item';
import { SetupItemService } from './setup-item-service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ApiResult } from '../../base.service';
import { BaseFormComponent } from '../../base.form.component'
@Component({
  selector: 'app-setup-item-edit',
  templateUrl: './setup-item-edit.component.html',
  styleUrls: ['./setup-item-edit.component.css', '../../../global.css']
})
export class SetupItemEditComponent extends BaseFormComponent implements OnInit {

  title: string;
  form: FormGroup;
  setupItem: SetupItem;
  setupId?: number;

  constructor(private activatedRoute: ActivatedRoute,
    private router: Router,
    private setupItemService: SetupItemService,
    @Inject('BASE_URL') private baseUrl: string) { super(); }

  ngOnInit() {
    this.form = new FormGroup({
      setupDesc: new FormControl('', Validators.required)
    }, null, this.isDuplicate());
    this.loadData();
  }

  loadData() {
    this.setupId = +this.activatedRoute.snapshot.paramMap.get("setupId");

    if (this.setupId) {
      //EDIT MODE
      this.setupItemService.get<SetupItem>(this.setupId)
        .subscribe(result => {
          this.setupItem = result;
          this.title = "Edit " + this.setupItem.setupDesc;

          this.form.patchValue(this.setupItem);
        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = 'Create a new Setup Item';
    }
  }

  isDuplicate(): AsyncValidatorFn {
    return (control: AbstractControl): Observable<{ [key: string]: any } | null> => {
      var setupItem = <SetupItem>{};
      setupItem.setupId = (this.setupId) ? this.setupId : 0;
      setupItem.setupDesc = this.form.get("setupDesc").value;

      return this.setupItemService.isDuplicate(setupItem)
        .pipe(map(result => {
          return (result ? { isDuplicate: true } : null);
        }));
    }
  }

  onSubmit() {
    var setupItem = (this.setupId) ? this.setupItem : <SetupItem>{};

    setupItem.setupDesc = this.form.get("setupDesc").value;

    if (this.setupId) {
      //EDIT MODE
      this.setupItemService.put<SetupItem>(setupItem)
        .subscribe(result => {
          console.log("Setup Item " + setupItem.setupId + " has been updated.");
          this.router.navigate(['/setupItems']);
        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.setupItemService.post<SetupItem>(setupItem)
        .subscribe(result => {
          console.log("Setup Item " + result.setupId + " has been created.");
          this.router.navigate(['/setupItems']);
        }, error => console.error(error));
    }
  }

  onDelete() {
    var setupItem = (this.setupId) ? this.setupItem : <SetupItem>{};
    this.setupItemService.delete<SetupItem>(this.setupItem.setupId)
      .subscribe(result => {
        console.log("Setup Item " + setupItem.setupId + " has been deleted.");
        this.router.navigate(['/setupItems']);
      }, error => console.error(error));
  }

}
