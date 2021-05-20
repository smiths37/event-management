import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../base.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class PersonService extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  //Get all people
  getData<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
    Observable<ApiResult> {
    var url = this.baseUrl + 'api/people';
    var params = new HttpParams()
      .set("pageIndex", pageIndex.toString())
      .set("pageSize", pageSize.toString())
      .set("sortColumn", sortColumn.toString())
      .set("sortOrder", sortOrder.toString())
    if (filterQuery) {
      params = params
        .set("filterColumn", filterColumn.toString())
        .set("filterQuery", filterQuery.toString())
    }
    return this.http.get<ApiResult>(url, { params });
  }

  get<Person>(id): Observable<Person> {
    var url = this.baseUrl + "api/people/" + id;
    return this.http.get<Person>(url);
  }

  put<Person>(item): Observable<Person> {
    var url = this.baseUrl + "api/people/" + item.personId;
    return this.http.put<Person>(url, item);
  }

  post<Person>(item): Observable<Person> {
    var url = this.baseUrl + "api/people/";
    return this.http.post<Person>(url, item);
  }

  delete<Person>(id): Observable<Person> {
    var url = this.baseUrl + "api/people/" + id;
    return this.http.delete<Person>(url);
  }

}
