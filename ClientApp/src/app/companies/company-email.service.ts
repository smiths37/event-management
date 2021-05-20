import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../base.service';
import { Observable } from 'rxjs';
import { CompanyEmail } from './company-email';

@Injectable({
  providedIn: 'root',
})
export class CompanyEmailService
  extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  getData<ApiResult>(
    pageIndex: number,
    pageSize: number,
    sortColumn: string,
    sortOrder: string,
    filterColumn: string,
    filterQuery: string
  ): Observable<ApiResult> {
    var url = this.baseUrl + 'api/CompanyEmails';
    var params = new HttpParams()
      .set("pageIndex", pageIndex.toString())
      .set("pageSize", pageSize.toString())
      .set("sortColumn", sortColumn)
      .set("sortOrder", sortOrder);

    if (filterQuery) {
      params = params
        .set("filterColumn", filterColumn)
        .set("filterQuery", filterQuery);
    }

    return this.http.get<ApiResult>(url, { params });
  }

  //Get one
  get<CompanyEmail>(id): Observable<CompanyEmail> {
    var url = this.baseUrl + "api/CompanyEmails/" + id;
    return this.http.get<CompanyEmail>(url);
  }

  //update 
  put<CompanyEmail>(item): Observable<CompanyEmail> {
    var url = this.baseUrl + 'api/CompanyEmails/' + item.emailId;
    return this.http.put<CompanyEmail>(url, item);
  }

  //add
  post<CompanyEmail>(item): Observable<CompanyEmail> {
    var url = this.baseUrl + 'api/CompanyEmails/';
    console.log("Item passed to Service: " + item.EmailAddress);
    return this.http.post<CompanyEmail>(url, item);
  }

  //delete
  delete<CompanyEmail>(id): Observable<CompanyEmail> {
    var url = this.baseUrl + "api/CompanyEmails/" + id;
    return this.http.delete<CompanyEmail>(url);
  }

}
