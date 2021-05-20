import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
//import { HttpClient, HttpParams } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { EmailType } from './email-Type';
import { EmailTypeService } from './email-types.service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ApiResult } from '../../base.service';
import { BaseFormComponent } from '../../base.form.component'

@Component({
  selector: 'app-email-emailType-edit',
  templateUrl: './email-type-edit.component.html',
  styleUrls: ['./email-type-edit.component.css', '../../../global.css']
})
export class EmailTypeEditComponent extends BaseFormComponent implements OnInit {
  title: string;
  form: FormGroup;
  emailType: EmailType;
  emailTypeId?: number;

  constructor(private activatedRoute: ActivatedRoute,
    private router: Router,
    //private http: HttpClient,
    private emailTypeService: EmailTypeService,
    @Inject('BASE_URL') private baseUrl: string) { super(); }

  ngOnInit() {
    this.form = new FormGroup({
      emailTypeDesc: new FormControl('', Validators.required)
    }, null, this.isDuplicate());
    this.loadData();
  }

  loadData() {
    this.emailTypeId = +this.activatedRoute.snapshot.paramMap.get("emailTypeId");

    if (this.emailTypeId) {
      //EDIT MODE
      //var url = this.baseUrl + "api/emailTypes/" + this.emailTypeId;
      //this.http.get<EmailType>(url)
      this.emailTypeService.get<EmailType>(this.emailTypeId)
        .subscribe(result => {
        this.emailType = result;
        this.title = "Edit " + this.emailType.emailTypeDesc;

        this.form.patchValue(this.emailType);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = 'Create a new Email Type';
    }
  }

  isDuplicate(): AsyncValidatorFn {
    return (control: AbstractControl): Observable<{ [key: string]: any } | null> => {
      var emailType = <EmailType>{};
      emailType.emailTypeId = (this.emailTypeId) ? this.emailTypeId : 0;
      emailType.emailTypeDesc = this.form.get("emailTypeDesc").value;

      //var url = this.baseUrl + "api/emailTypes/IsDuplicate";
      //return this.http.post<boolean>(url, emailType)
      return this.emailTypeService.isDuplicate(emailType)
        .pipe(map(result => {
        return (result ? { isDuplicate: true } : null);
      }));
    }
  }

  onSubmit() {
    var emailType = (this.emailTypeId) ? this.emailType : <EmailType>{};

    emailType.emailTypeDesc = this.form.get("emailTypeDesc").value;

    if (this.emailTypeId) {
      //EDIT MODE
      //var url = this.baseUrl + "api/emailTypes/" + this.emailType.emailTypeId;
      //this.http.put<EmailType>(url, emailType)
      this.emailTypeService.put<EmailType>(emailType)
        .subscribe(result => {
        console.log("Email Type " + emailType.emailTypeId + " has been updated.");
        this.router.navigate(['/emailTypes']);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      //var url = this.baseUrl = "api/emailTypes";
      //this.http.post<EmailType>(url, emailType)
      this.emailTypeService.post<EmailType>(emailType)
        .subscribe(result => {
        console.log("Email Type " + result.emailTypeId + " has been created.");
        this.router.navigate(['/emailTypes']);
      }, error => console.error(error));
    }
  }

  onDelete() {
    var emailType = (this.emailTypeId) ? this.emailType : <EmailType>{};
    //var url = this.baseUrl = 'api/emailTypes/' + this.emailType.emailTypeId;
    //this.http.delete<EmailType>(url)
    this.emailTypeService.delete<EmailType>(emailType.emailTypeId)
      .subscribe(result => {
      console.log("Email Type " + emailType.emailTypeId + " has been deleted.");
      this.router.navigate(['/emailTypes']);
    }, error => console.error(error));
  }

}
