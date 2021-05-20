import { Component, Inject, ViewChild, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { CompanyEmail } from './company-email';
import { CompanyEmailService } from './company-email.service';
import { EmailType } from '../maintenance/email-types/email-type';
import { EmailTypeService } from '../maintenance/email-types/email-types.service';

import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ApiResult } from '../base.service';
import { BaseFormComponent } from '../base.form.component'
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';

@Component({
  selector: 'app-company-email-edit',
  templateUrl: './company-email-edit.component.html',
  styleUrls: ['../../global.css']
})

export class CompanyEmailEditComponent extends BaseFormComponent implements OnInit {
  title: string;
  form: FormGroup;
  email: CompanyEmail;
  emailId?: number;
  companyId?: number;
  emailTypes: EmailType[];

  constructor(
    private activatedRoute: ActivatedRoute,
    private router: Router,
    private companyEmailService: CompanyEmailService,
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
    this.companyId = +this.activatedRoute.snapshot.paramMap.get('companyId');
    this.emailId = +this.activatedRoute.snapshot.paramMap.get('emailId');

    if (this.emailId) {
      //EDIT MODE
      var url = this.baseUrl + "api/companyEmails/" + this.emailId;
      this.companyEmailService.get<CompanyEmail>(this.emailId)
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
    this.companyId = +this.activatedRoute.snapshot.paramMap.get('companyId'); 

    var thisEmail = (this.emailId) ? this.email : <CompanyEmail>{};
    thisEmail.companyId = this.companyId;
    thisEmail.EmailAddress = this.form.get("emailAddress").value;
    console.log("Email address field value = " + this.form.get("emailAddress").value);
    thisEmail.emailType = this.form.get("emailType").value;

    console.log(thisEmail);

    if (this.emailId) {
      //EDIT MODE
      this.companyEmailService.put<CompanyEmail>(thisEmail)
        .subscribe(result => {
          console.log("Company Email " + thisEmail.emailId + " has been updated.");
          this.router.navigate(['/company', this.companyId]);
        }, error => console.log(error));
    } else {
      //ADD NEW MODE
      this.companyEmailService.post<CompanyEmail>(thisEmail)
        .subscribe(result => {
          console.log("Company Email " + thisEmail.emailId + " has been created.");
          this.router.navigate(['/company', this.companyId]);
        }, error => console.log(error));
    }
  }

  onDelete() {
    var email = (this.emailId) ? this.email : <CompanyEmail>{};

    this.companyEmailService.delete<CompanyEmail>(email.emailId)
      .subscribe(result => {
        console.log("Company Email" + email.emailId + " has been deleted.");
        this.router.navigate(['/company', this.companyId]);
      }, error => console.error(error));
  }
}
