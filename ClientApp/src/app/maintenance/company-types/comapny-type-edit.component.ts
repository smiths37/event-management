import { Component, Inject, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
//import { HttpClient, HttpParams } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { CompanyType } from './company-type';
import { CompanyTypeService } from './company-type.service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ApiResult } from '../../base.service';
import { BaseFormComponent } from '../../base.form.component'
import { Company } from '../../companies/company';

@Component({
  selector: 'app-comapny-type-edit',
  templateUrl: './comapny-type-edit.component.html',
  styleUrls: ['./comapny-type-edit.component.css', '../../../global.css']
})
export class CompanyTypeEditComponent extends BaseFormComponent implements OnInit {
  title: string;
  form: FormGroup;
  companyType: CompanyType;
  companyTypeId?: number;

  constructor(
    private activatedRoute: ActivatedRoute,
    private router: Router,
    //private http: HttpClient,
    private companyTypeService: CompanyTypeService,
    @Inject('BASE_URL') private baseUrl: string
  ) { super(); }

  ngOnInit() {
    this.form = new FormGroup({
      companyTypeDesc: new FormControl('', Validators.required)
    }, null, this.isDuplicate());
    this.loadData();
  }

  loadData() {
    this.companyTypeId = +this.activatedRoute.snapshot.paramMap.get("companyTypeId");

    if (this.companyTypeId) {
      //EDIT MODE
      //var url = this.baseUrl + "api/companyTypes/" + this.companyTypeId;
      //this.http.get<CompanyType>(url)
      this.companyTypeService.get<CompanyType>(this.companyTypeId)
        .subscribe(result => {
        this.companyType = result;
        this.title = "Edit " + this.companyType.companyTypeDesc;

        this.form.patchValue(this.companyType);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = 'Create a new Company Type';
    }
  }

  isDuplicate(): AsyncValidatorFn {
    return (control: AbstractControl): Observable<{ [key: string]: any } | null> => {
      var companyType = <CompanyType>{};
      companyType.companyTypeId = (this.companyTypeId) ? this.companyTypeId : 0;
      companyType.companyTypeDesc = this.form.get("companyTypeDesc").value;

      //var url = this.baseUrl + "api/companyTypes/IsDuplicate";
      //return this.http.post<boolean>(url, companyType)
      return this.companyTypeService.isDuplicate(companyType)
        .pipe(map(result => {
        return (result ? { isDuplicate: true } : null);
      }));
    }
  }

  onSubmit() {
    var companyType = (this.companyTypeId) ? this.companyType : <CompanyType>{};

    companyType.companyTypeDesc = this.form.get("companyTypeDesc").value;

    if (this.companyTypeId) {
      //EDIT MODE
      //var url = this.baseUrl + "api/companyTypes/" + this.companyType.companyTypeId;
      //this.http.put<CompanyType>(url, companyType)
      this.companyTypeService.put<CompanyType>(this.companyType)
        .subscribe(result => {
        console.log("Company Type " + companyType.companyTypeId + " has been updated.");
        this.router.navigate(['/companyTypes']);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      //var url = this.baseUrl = "api/companyTypes";
      //this.http.post<CompanyType>(url, companyType)
      this.companyTypeService.post<CompanyType>(companyType)
        .subscribe(result => {
        console.log("Company Type " + result.companyTypeId + " has been created.");
        this.router.navigate(['/companyTypes']);
      }, error => console.error(error));
    }
  }

  onDelete() {
    var companyType = (this.companyTypeId) ? this.companyType : <CompanyType>{};
    //var url = this.baseUrl = 'api/companyTypes/' + this.companyType.companyTypeId;
    //this.http.delete<CompanyType>(url)
    this.companyTypeService.delete<CompanyType>(companyType.companyTypeId)
      .subscribe(result => {
      console.log("Company Type " + companyType.companyTypeId + " has been deleted.");
      this.router.navigate(['/companyTypes']);
    }, error => console.error(error));
  }


}
