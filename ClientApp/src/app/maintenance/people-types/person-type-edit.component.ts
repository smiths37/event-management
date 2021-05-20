import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
//import { HttpClient, HttpParams } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { PeopleType } from './people-Type';
import { PeopleTypeService } from './people-type-service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ApiResult } from '../../base.service';
import { BaseFormComponent } from '../../base.form.component'

@Component({
  selector: 'app-person-type-edit',
  templateUrl: './person-type-edit.component.html',
  styleUrls: ['./person-type-edit.component.css', '../../../global.css']
})
export class PersonTypeEditComponent extends BaseFormComponent implements OnInit {
  title: string;
  form: FormGroup;
  peopleType: PeopleType;
  peopleTypeId?: number;

  constructor(private activatedRoute: ActivatedRoute,
    private router: Router,
    private peopleTypeService: PeopleTypeService,
    @Inject('BASE_URL') private baseUrl: string) { super(); }

  ngOnInit() {
    this.form = new FormGroup({
      peopleTypeDesc: new FormControl('', Validators.required)
    }, null, this.isDuplicate());
    this.loadData();
  }

  loadData() {
    this.peopleTypeId = +this.activatedRoute.snapshot.paramMap.get("peopleTypeId");

    if (this.peopleTypeId) {
      //EDIT MODE
      this.peopleTypeService.get<PeopleType>(this.peopleTypeId)
        .subscribe(result => {
          this.peopleType = result;
          this.title = "Edit " + this.peopleType.peopleTypeDesc;

          this.form.patchValue(this.peopleType);
        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = 'Create a new Payment Type';
    }
  }

  isDuplicate(): AsyncValidatorFn {
    return (control: AbstractControl): Observable<{ [key: string]: any } | null> => {
      var peopleType = <PeopleType>{};
      peopleType.peopleTypeId = (this.peopleTypeId) ? this.peopleTypeId : 0;
      peopleType.peopleTypeDesc = this.form.get("peopleTypeDesc").value;

      return this.peopleTypeService.isDuplicate(peopleType)
        .pipe(map(result => {
          return (result ? { isDuplicate: true } : null);
        }));
    }
  }

  onSubmit() {
    var peopleType = (this.peopleTypeId) ? this.peopleType : <PeopleType>{};

    peopleType.peopleTypeDesc = this.form.get("peopleTypeDesc").value;

    if (this.peopleTypeId) {
      //EDIT MODE
      this.peopleTypeService.put<PeopleType>(peopleType)
        .subscribe(result => {
          console.log("Payment Type " + peopleType.peopleTypeId + " has been updated.");
          this.router.navigate(['/peopleTypes']);
        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.peopleTypeService.post<PeopleType>(peopleType)
        .subscribe(result => {
          console.log("Payment Type " + result.peopleTypeId + " has been created.");
          this.router.navigate(['/peopleTypes']);
        }, error => console.error(error));
    }
  }

  onDelete() {
    var peopleType = (this.peopleTypeId) ? this.peopleType : <PeopleType>{};
    this.peopleTypeService.delete<PeopleType>(this.peopleType.peopleTypeId)
      .subscribe(result => {
        console.log("Payment Type " + peopleType.peopleTypeId + " has been deleted.");
        this.router.navigate(['/peopleTypes']);
      }, error => console.error(error));
  }

}
