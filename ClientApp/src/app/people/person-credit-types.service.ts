import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../base.service';
import { Observable } from 'rxjs';
import { PersonCreditType } from './person-credit-type';

@Injectable({
  providedIn: 'root',
})
export class PeopleCreditTypeService
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
    var url = this.baseUrl + 'api/PeopleCreditTypes';
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
  get<PersonCreditType>(id): Observable<PersonCreditType> {
    var url = this.baseUrl + "api/PeopleCreditTypes/" + id;
    return this.http.get<PersonCreditType>(url);
  }

  //update 
  put<PersonCreditType>(item): Observable<PersonCreditType> {
    var url = this.baseUrl + 'api/PeopleCreditTypes/' + item.id;
    return this.http.put<PersonCreditType>(url, item);
  }

  //add
  post<PersonCreditType>(item): Observable<PersonCreditType> {
    var url = this.baseUrl + 'api/PeopleCreditTypes/';
    return this.http.post<PersonCreditType>(url, item);
  }

  //delete 
  delete<PersonCreditType>(id): Observable<PersonCreditType> {
    var url = this.baseUrl + "api/PeopleCreditTypes/" + id;
    return this.http.delete<PersonCreditType>(url);
  }
}
