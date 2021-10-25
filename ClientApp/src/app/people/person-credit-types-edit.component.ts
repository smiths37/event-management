import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';

import { PersonCreditType } from './person-credit-type';
import { PeopleCreditTypeService } from './person-credit-types.service';

import { from, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ApiResult } from '../base.service';
import { BaseFormComponent } from '../base.form.component'

import { CreditType } from '../maintenance/credit-types/credit-type';
import { CreditTypeService } from '../maintenance/credit-types/credit-types.service';

@Component({
  selector: 'app-person-credit-types-edit',
  templateUrl: './person-credit-types-edit.component.html',
  styleUrls: ['../../global.css']
})

export class PersonCreditTypeEditComponent extends BaseFormComponent implements OnInit {
  title: string;
  form: FormGroup;
  personCreditType: PersonCreditType;
  id?: number;
  personId?: number;
  creditTypes: CreditType[];
  creditType: CreditType;

  constructor(
    private activatedRoute: ActivatedRoute,
    private router: Router,
    private http: HttpClient,
    private peopleCreditTypeService: PeopleCreditTypeService,
    private creditTypeService: CreditTypeService,
    @Inject('BASE_URL') private baseUrl: string
  ) { super(); }

  ngOnInit() {
    this.form = new FormGroup({
      creditTypeCode: new FormControl('', Validators.required),
      creditTypeDesc: new FormControl(''),   //readonly field
    }, null);
    this.loadData();
  }

  loadData() {
    this.loadCreditTypes();

    this.id = +this.activatedRoute.snapshot.paramMap.get("id");
    this.personId = +this.activatedRoute.snapshot.paramMap.get("personId");

    if (this.personId && this.id) {
      //EDIT MODE
      this.peopleCreditTypeService.get<PersonCreditType>(this.id)
        .subscribe(result => {
          this.personCreditType = result;
          this.title = "Edit Person Credit Type";
          this.form.patchValue(this.personCreditType);
          //this.form.get("creditTypeCode").setValue(this.personCreditType.creditTypeCode);
          this.onCreditTypeSelected(result);
          console.log(result);
        }, error => console.log(error));
    } else {
      //ADD NEW MODE
      this.title="Add a new Person Credit Type"
    }
  }

  loadCreditTypes() {
    this.creditTypeService.getData<ApiResult<CreditType>>(0, 9999, "creditTypeDesc", "asc", null, null)
      .subscribe(result => {
        this.creditTypes = result.data;
      }, error => console.log(error));
  }
  onCreditTypeSelected(object) {
    //this.form.get("creditTypeDesc").setValue(this.form.get("creditTypeCode").value);

    //get the credit type description
    this.creditTypeService.get<CreditType>(this.form.get("creditTypeCode").value)
      .subscribe(result => {
        this.creditType = result;
        this.form.get("creditTypeDesc").setValue(this.creditType.creditTypeDesc);
      })
  }

  onSubmit() {
    var personCreditType = (this.id) ? this.personCreditType : <PersonCreditType>{};
    personCreditType.personId = this.personId;
    personCreditType.creditTypeCode = this.form.get("creditTypeCode").value;

    if (this.id) {
      //EDIT MODE
      this.peopleCreditTypeService.put<PersonCreditType>(personCreditType)
        .subscribe(result => {
          console.log("Person Credit Type " + personCreditType.id + " has been updated");
          this.router.navigate(["/person", this.personId]);
        }, error => console.log(error));
    } else {
      //ADD NEW MODE
      this.peopleCreditTypeService.post<PersonCreditType>(personCreditType)
        .subscribe(result => {
          console.log("Person Credit Type " + personCreditType.id + " has been created");
          this.router.navigate(["/person", this.personId]);
        }, error => console.log(error));
    }
  }

  onDelete() {
    var personCreditType = (this.id) ? this.personCreditType : <PersonCreditType>{};

    this.peopleCreditTypeService.delete<PersonCreditType>(personCreditType.id)
      .subscribe(result => {
        console.log("Person Credit Type " + personCreditType.id + " has been deleted.");
        this.router.navigate(["/person", this.personId]);
      }, error => console.log(error));
  }
}
