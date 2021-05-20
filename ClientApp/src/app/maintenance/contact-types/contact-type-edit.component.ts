import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
//import { HttpClient, HttpParams } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { ContactType } from './contact-type';
import { ContactTypeService } from './contact-types.service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ApiResult } from '../../base.service';
import { BaseFormComponent } from '../../base.form.component'

@Component({
  selector: 'app-contact-type-edit',
  templateUrl: './contact-type-edit.component.html',
  styleUrls: ['./contact-type-edit.component.css', '../../../global.css']
})
export class ContactTypeEditComponent extends BaseFormComponent implements OnInit {
  title: string;
  form: FormGroup;
  contactType: ContactType;
  contactTypeId?: number;

  constructor(private activatedRoute: ActivatedRoute,
    private router: Router,
    //private http: HttpClient,
    private contactTypeService: ContactTypeService,
    @Inject('BASE_URL') private baseUrl: string) { super();}

  ngOnInit() {
    this.form = new FormGroup({
      contactTypeDesc: new FormControl('', Validators.required)
    }, null, this.isDuplicate());
    this.loadData();
  }

  loadData() {
    this.contactTypeId = +this.activatedRoute.snapshot.paramMap.get("contactTypeId");

    if (this.contactTypeId) {
      //EDIT MODE
      //var url = this.baseUrl + "api/contactTypes/" + this.contactTypeId;
      //this.http.get<ContactType>(url)
      this.contactTypeService.get<ContactType>(this.contactTypeId)
        .subscribe(result => {
        this.contactType = result;
        this.title = "Edit " + this.contactType.contactTypeDesc;

        this.form.patchValue(this.contactType);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = 'Create a new Contact Type';
    }
  }

  isDuplicate(): AsyncValidatorFn {
    return (control: AbstractControl): Observable<{ [key: string]: any } | null> => {
      var contactType = <ContactType>{};
      contactType.contactTypeId = (this.contactTypeId) ? this.contactTypeId : 0;
      contactType.contactTypeDesc = this.form.get("contactTypeDesc").value;

      //var url = this.baseUrl + "api/contactTypes/IsDuplicate";
      //return this.http.post<boolean>(url, contactType)
      return this.contactTypeService.isDuplicate(contactType)
        .pipe(map(result => {
        return (result ? { isDuplicate: true } : null);
      }));
    }
  }

  onSubmit() {
    var contactType = (this.contactTypeId) ? this.contactType : <ContactType>{};

    contactType.contactTypeDesc = this.form.get("contactTypeDesc").value;

    if (this.contactTypeId) {
      //EDIT MODE
      //var url = this.baseUrl + "api/contactTypes/" + this.contactType.contactTypeId;
      //this.http.put<ContactType>(url, contactType)
      this.contactTypeService.put<ContactType>(this.contactType)
        .subscribe(result => {
        console.log("Contact Type " + contactType.contactTypeId + " has been updated.");
        this.router.navigate(['/contactTypes']);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      //var url = this.baseUrl = "api/contactTypes";
      //this.http.post<ContactType>(url, contactType)
      this.contactTypeService.post<ContactType>(contactType)
        .subscribe(result => {
        console.log("Contact Type " + result.contactTypeId + " has been created.");
        this.router.navigate(['/contactTypes']);
      }, error => console.error(error));
    }
  }

  onDelete() {
    var contactType = (this.contactTypeId) ? this.contactType : <ContactType>{};
    //var url = this.baseUrl = 'api/contactTypes/' + this.contactType.contactTypeId;
    //this.http.delete<ContactType>(url)
    this.contactTypeService.delete<ContactType>(contactType.contactTypeId)
      .subscribe(result => {
      console.log("Contact Type " + contactType.contactTypeId + " has been deleted.");
      this.router.navigate(['/contactTypes']);
    }, error => console.error(error));
  }

}
