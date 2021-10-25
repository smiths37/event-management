import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { DatePipe } from '@angular/common';
import { NgbDate } from '@ng-bootstrap/ng-bootstrap';

import { PersonCeCredit } from './person-ce-credit';
import { PeopleCeCreditsService } from './person-ce-credits.service';

import { from, Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ApiResult } from '../base.service';
import { BaseFormComponent } from '../base.form.component'

import { CreditType } from '../maintenance/credit-types/credit-type';
import { CreditTypeService } from '../maintenance/credit-types/credit-types.service';

@Component({
  selector: 'app-person-ce-credit-edit',
  templateUrl: './person-ce-credits-edit.component.html',
  styleUrls: ['../../global.css'],
  providers: [DatePipe]
})

export class PersonCeCreditEditComponent extends BaseFormComponent implements OnInit {
  title: string;
  form: FormGroup;
  personCeCredit: PersonCeCredit;
  keyId?: number;
  personId?: number;
  creditTypes: CreditType[];
  creditDateModel: NgbDate;

  constructor(private activatedRoute: ActivatedRoute,
  private router: Router,
  private http: HttpClient,
  private peopleCeCreditService: PeopleCeCreditsService,
  private creditTypeService: CreditTypeService,
  private datePipe: DatePipe,
  @Inject('BASE_URL') private baseUrl: string
  ) { super(); }

  ngOnInit() {
    this.form = new FormGroup({
      creditDate: new FormControl(''),
      title: new FormControl(''),
      meetingCode: new FormControl(''),
      regCode: new FormControl(''),
      sessionCode: new FormControl(''),
      creditTypeCode: new FormControl(''),
      creditUnits: new FormControl(''),
      selfReported: new FormControl('')
    }, null);
    this.loadData();
  }

  loadData() {
    this.loadCreditTypes();

    this.keyId = +this.activatedRoute.snapshot.paramMap.get("keyId");
    this.personId = +this.activatedRoute.snapshot.paramMap.get("personId");

    if (this.personId && this.keyId) {
      //EDIT MODE
      this.peopleCeCreditService.get<PersonCeCredit>(this.keyId)
        .subscribe(result => {
          this.personCeCredit = result;
          this.title = "Edit Person Credit";
          this.form.patchValue(this.personCeCredit); 

          //format credit date field
          const creditYear = Number(this.datePipe.transform(this.personCeCredit.creditDate, 'yyyy'));
          const creditMonth = Number(this.datePipe.transform(this.personCeCredit.creditDate, 'MM'));
          const creditDay = Number(this.datePipe.transform(this.personCeCredit.creditDate, "dd"));
          this.form.get("creditDate").setValue({
            year: creditYear,
            month: creditMonth,
            day: creditDay
          });

        }, error => console.log(error));
    } else {
      //ADD NEW MODE
      this.title = "Add a new Person Credit"
    }
  }

  loadCreditTypes() {
    this.creditTypeService.getData<ApiResult<CreditType>>(0, 9999, "creditTypeDesc", "asc", null, null)
      .subscribe(result => {
        this.creditTypes = result.data;
      }, error => console.log(error));
  }

  onSubmit() {
    var personceCeCredit = (this.keyId) ? this.personCeCredit : <PersonCeCredit>{};
    personceCeCredit.personId = this.personId;

    //check for null date values and if value exists - need to do this so that the null value doesn't try to get converted to a datetime
    if (this.form.get("creditDate").value && (this.form.get("creditDate").value != null || this.form.get("creditDate").value != '')) {
      //Date picker passes back JSON date, format this as a date to send to DB
      var year: string;
      var day: string;
      var month: string;
      var fullDate: Date;
      year = this.form.get("creditDate").value.year;
      day = this.form.get("creditDate").value.day;
      month = this.form.get("creditDate").value.month;
      fullDate = new Date(year + "-" + month + "-" + day);
      personceCeCredit.creditDate = fullDate;
    }
    //Check for blank values on non-required fields
    this.form.get("title").value == "" ? personceCeCredit.title = null : personceCeCredit.title = this.form.get("title").value;
    this.form.get("meetingCode").value == "" ? personceCeCredit.meetingCode = null : personceCeCredit.meetingCode = this.form.get("meetingCode").value;
    this.form.get("regCode").value == "" ? personceCeCredit.regCode = null : personceCeCredit.regCode = this.form.get("regCode").value;
    this.form.get("sessionCode").value == "" ? personceCeCredit.sessionCode = null : personceCeCredit.sessionCode = this.form.get("sessionCode").value;
    this.form.get("creditTypeCode").value == "" ? personceCeCredit.creditTypeCode = null : personceCeCredit.creditTypeCode = this.form.get("creditTypeCode").value;
    this.form.get("creditUnits").value == "" ? personceCeCredit.creditUnits = null : personceCeCredit.creditUnits = this.form.get("creditUnits").value;
    //check value of checkbox
    if (this.form.controls["selfReported"].value == "" || this.form.controls["selfReported"].value == null) {
      personceCeCredit.selfReported = false;
    } else {
      personceCeCredit.selfReported = true;
    }

    if (this.keyId) {
      //EDIT MODE
      this.peopleCeCreditService.put<PersonCeCredit>(personceCeCredit)
        .subscribe(result => {
          console.log("Person Credit " + personceCeCredit.keyId + " has been updated");
          this.router.navigate(["/person", this.personId]);
        }, error => console.log(error));
    } else {
      //ADD NEW MODE
      this.peopleCeCreditService.post<PersonCeCredit>(personceCeCredit)
        .subscribe(result => {
          console.log("Person Credit " + personceCeCredit.keyId + " has been created");
          this.router.navigate(["/person", this.personId]);
        }, error => console.log(error));
    }
  }

  onDelete() {
    var personCeCredit = (this.keyId) ? this.personCeCredit : <PersonCeCredit>{};

    this.peopleCeCreditService.delete<PersonCeCredit>(personCeCredit.keyId)
      .subscribe(result => {
        console.log("Person Credit " + personCeCredit.keyId + " has been deleted.");
        this.router.navigate(["/person", this.personId]);
      }, error => console.log(error));
  }
}
