import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../base.service';
import { Observable } from 'rxjs';
import { PersonEmail } from './person-email';

@Injectable({
  providedIn: 'root',
})
export class PeopleEmailService
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
    var url = this.baseUrl + 'api/PeopleEmails';
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
  get<PeopleEmail>(id): Observable<PeopleEmail> {
    var url = this.baseUrl + "api/PeopleEmails/" + id;
    return this.http.get<PeopleEmail>(url);
  }

  //getEmailByPersonIdAndAddress<PeopleEmail>(personId, emailAddress): Observable<PeopleEmail> {
  //  var url = this.baseUrl + "api/PeopleEmails/" + personId + "/" + emailAddress;
  //  return this.http.get<PeopleEmail>(url);
  //}

  //update 
  put<PeopleEmail>(item): Observable<PeopleEmail> {
    var url = this.baseUrl + 'api/PeopleEmails/' + item.emailId;
    return this.http.put<PeopleEmail>(url, item);
  }

  //add
  post<PeopleEmail>(item): Observable<PeopleEmail> {
    var url = this.baseUrl + 'api/PeopleEmails/';
    return this.http.post<PeopleEmail>(url, item);
  }

  //delete 
  delete<PeopleEmail>(id): Observable<PeopleEmail> {
    var url = this.baseUrl + "api/PeopleEmails/" + id;
    return this.http.delete<PeopleEmail>(url);
  }

  //deleteEmailByPersonIdAndAddress<PeopleEmail>(personId, emailAddress): Observable<PeopleEmail> {
  //  var url = this.baseUrl + "api/PeopleEmails/" + personId + "/" + emailAddress;
  //  return this.http.delete<PeopleEmail>(url);
  //}

}
