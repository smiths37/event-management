import { Component, Inject, ViewChild, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { PersonEmail } from './person-email';
import { PeopleEmailService } from './person-email.service';
import { EmailType } from '../maintenance/email-types/email-type';
import { EmailTypeService } from '../maintenance/email-types/email-types.service';

import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ApiResult } from '../base.service';
import { BaseFormComponent } from '../base.form.component'
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';

@Component({
  selector: 'app-person-email-edit',
  templateUrl: './person-email-edit.component.html',
  styleUrls: ['../../global.css']
})

export class PersonEmailEditComponent extends BaseFormComponent implements OnInit {
  title: string;
  form: FormGroup;
  email: PersonEmail;
  emailId?: number;
  personId?: number;
  emailTypes: EmailType[];
  //emailAddress: string;

  constructor(
    private activatedRoute: ActivatedRoute,
    private router: Router,
    private personEmailService: PeopleEmailService,
    private emailTypeService: EmailTypeService,
    @Inject('BASE_URL') private baseUrl: string
  ) {
    super();
  }

  ngOnInit() {
    this.form = new FormGroup({
      emailAddress: new FormControl('', Validators.required),
      emailType: new FormControl('', Validators.required),
    });
    this.loadData();
  }

  loadData() {
    this.loadEmailTypes();
    this.personId = +this.activatedRoute.snapshot.paramMap.get('personId');
    this.emailId = +this.activatedRoute.snapshot.paramMap.get('emailId');
    //this.emailAddress = this.activatedRoute.snapshot.paramMap.get("emailAddress");
    console.log(this.activatedRoute.snapshot.paramMap);

    if (this.emailId) {
      //EDIT MODE
      var url = this.baseUrl + "api/PeopleEmails/" + this.emailId;
      this.personEmailService.get<PersonEmail>(this.emailId)
        .subscribe(result => {
          this.email = result;
          console.log(result);
          this.title = "Edit Email";

          this.form.patchValue(this.email);

        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = "Add a new Email";
    }
  }

  loadEmailTypes() {
    this.emailTypeService.getData<ApiResult<EmailType>>(0, 9999, "emailTypeDesc", "asc", null, null)
      .subscribe(result => {
        this.emailTypes = result.data;
      },
        error => console.log(error));
  }

  onSubmit() {
    this.personId = +this.activatedRoute.snapshot.paramMap.get('personId');
    this.emailId = +this.activatedRoute.snapshot.paramMap.get('emailId');

    var thisEmail = (this.emailId) ? this.email : <PersonEmail>{};
    //var thisEmail = (this.personId && this.emailAddress) ? this.email : <PersonEmail>{};

    thisEmail.personId = this.personId;
    thisEmail.emailId = this.emailId;
    //thisEmail.emailAddress = this.emailAddress;
    console.log("Email address field value = " + this.form.get("emailAddress").value);
    thisEmail.emailAddress = this.form.get("emailAddress").value;
    thisEmail.emailType = this.form.get("emailType").value;
    console.log('Email Type selected' + this.form.get("emailType").value);

    if (this.emailId) {
      //EDIT MODE
      this.personEmailService.put<PersonEmail>(thisEmail)
        .subscribe(result => {
          console.log("Person Email " + thisEmail.emailId + " has been updated.");
          this.router.navigate(['/person', this.personId]);
        }, error => console.log(error));
    } else {
      //ADD NEW MODE
      this.personEmailService.post<PersonEmail>(thisEmail)
        .subscribe(result => {
          console.log("Person Email " + thisEmail.emailId + " has been created.");
          this.router.navigate(['/person', this.personId]);
        }, error => console.log(error));
    }
  }

  onDelete() {
    var email = (this.emailId) ? this.email : <PersonEmail>{};
    //var email = (this.personId && this.emailAddress) ? this.email : <PersonEmail>{};

    this.personEmailService.delete<PersonEmail>(email.emailId)
    //this.personEmailService.deleteEmailByPersonIdAndAddress<PersonEmail>(email.personId, email.emailAddress)
      .subscribe(result => {
        console.log("Person Email" + email.emailId + " has been deleted.");
        this.router.navigate(['/person', this.personId]);
      }, error => console.error(error));
  }
}
