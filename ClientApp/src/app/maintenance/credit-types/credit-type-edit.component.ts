import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
//import { HttpClient, HttpParams } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { CreditType } from './credit-type';
import { CreditTypeService } from './credit-types.service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ApiResult } from '../../base.service';
import { BaseFormComponent } from '../../base.form.component'

@Component({
  selector: 'app-credit-type-edit',
  templateUrl: './credit-type-edit.component.html',
  styleUrls: ['./credit-type-edit.component.css', '../../../global.css']
})
export class CreditTypeEditComponent extends BaseFormComponent implements OnInit {
  title: string;
  form: FormGroup;
  creditType: CreditType;
  creditTypeId?: number;
  creditTypeCode?: string;

  constructor(private activatedRoute: ActivatedRoute,
    private router: Router,
    //private http: HttpClient,
    private creditTypeService: CreditTypeService,
    @Inject('BASE_URL') private baseUrl: string) { super(); }

  ngOnInit() {
    this.form = new FormGroup({
      creditTypeDesc: new FormControl('', Validators.required),
      creditTypeCode: new FormControl('', Validators.required),
      allowOnWeb: new FormControl('')
    }, null, this.isDuplicate());
    this.loadData();
  }

  loadData() {
    this.creditTypeCode = this.activatedRoute.snapshot.paramMap.get("creditTypeCode");

    if (this.creditTypeCode) {
      //EDIT MODE - CreditType uses the Code as the Primary Key/Unique identifer, but it still has an ID field
      //var url = this.baseUrl + "api/creditTypes/" + this.creditTypeCode;
      //this.http.get<CreditType>(url)
      this.creditTypeService.get<CreditType>(this.creditTypeCode)
        .subscribe(result => {
        this.creditType = result;
          this.title = "Edit " + this.creditType.creditTypeDesc;
          this.creditTypeCode = this.creditType.creditTypeCode;
          this.creditTypeId = this.creditType.creditTypeId;

        this.form.patchValue(this.creditType);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = 'Create a new Credit Type';
    }
  }

  isDuplicate(): AsyncValidatorFn {
    return (control: AbstractControl): Observable<{ [key: string]: any } | null> => {
      var creditType = <CreditType>{};
      creditType.creditTypeId = (this.creditTypeId) ? this.creditTypeId : 0;
      //creditType.creditTypeCode = (this.creditTypeCode) ? this.creditTypeCode : null;
      //console.log("Credit Type ID on isDuplicate = " + this.creditType.creditTypeId);
      creditType.creditTypeCode = this.form.get("creditTypeCode").value;
      creditType.creditTypeDesc = this.form.get("creditTypeDesc").value;

      //var url = this.baseUrl + "api/creditTypes/IsDuplicate";
      //return this.http.post<boolean>(url, creditType)
      return this.creditTypeService.isDuplicate(creditType)
        .pipe(map(result => {
        return (result ? { isDuplicate: true } : null);
      }));
    }
  }

  onSubmit() {
    var creditType = (this.creditTypeCode) ? this.creditType : <CreditType>{};

    creditType.creditTypeDesc = this.form.get("creditTypeDesc").value;
    creditType.creditTypeCode = this.form.get("creditTypeCode").value;
    creditType.creditTypeId = this.creditTypeId;
    console.log("Credit type id = " + this.creditTypeId);
    //creditType.allowOnWeb = this.form.get("allowOnWeb").value;

    if (this.form.controls["allowOnWeb"].value == "" || this.form.controls["allowOnWeb"].value == null) {
      creditType.allowOnWeb = false;
    } else {
      creditType.allowOnWeb = true;
    }

    if (this.creditTypeCode) {
      //EDIT MODE
      //var url = this.baseUrl + "api/creditTypes/" + this.creditType.creditTypeCode;
      //this.http.put<CreditType>(url, creditType)
      this.creditTypeService.put<CreditType>(this.creditType)
        .subscribe(result => {
        console.log("Credit Type " + creditType.creditTypeCode + " has been updated.");
        this.router.navigate(['/creditTypes']);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      //var url = this.baseUrl = "api/creditTypes";
      //this.http.post<CreditType>(url, creditType)
      this.creditTypeService.post<CreditType>(creditType)
        .subscribe(result => {
        console.log("Credit Type " + result.creditTypeCode + " has been created.");
        this.router.navigate(['/creditTypes']);
      }, error => console.error(error));
    }
  }

  onDelete() {
    var creditType = (this.creditTypeCode) ? this.creditType : <CreditType>{};
    //var url = this.baseUrl = 'api/creditTypes/' + this.creditType.creditTypeCode;
    //this.http.delete<CreditType>(url)
    this.creditTypeService.delete<CreditType>(creditType.creditTypeCode)
      .subscribe(result => {
      console.log("Credit Type " + creditType.creditTypeCode + " has been deleted.");
      this.router.navigate(['/creditTypes']);
    }, error => console.error(error));
  }

}
