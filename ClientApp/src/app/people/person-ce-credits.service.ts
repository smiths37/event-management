import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../base.service';
import { Observable } from 'rxjs';
import { PersonCeCredit } from './person-ce-credit';

@Injectable({
  providedIn: 'root',
})
export class PeopleCeCreditsService
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
    var url = this.baseUrl + 'api/PeopleCeCredits';
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
  get<PersonCeCredit>(id): Observable<PersonCeCredit> {
    var url = this.baseUrl + "api/PeopleCeCredits/" + id;
    return this.http.get<PersonCeCredit>(url);
  }

  //update 
  put<PersonCeCredit>(item): Observable<PersonCeCredit> {
    var url = this.baseUrl + 'api/PeopleCeCredits/' + item.keyId;
    return this.http.put<PersonCeCredit>(url, item);
  }

  //add
  post<PersonCeCredit>(item): Observable<PersonCeCredit> {
    var url = this.baseUrl + 'api/PeopleCeCredits/';
    return this.http.post<PersonCeCredit>(url, item);
  }

  //delete 
  delete<PersonCeCredit>(id): Observable<PersonCeCredit> {
    var url = this.baseUrl + "api/PeopleCeCredits/" + id;
    return this.http.delete<PersonCeCredit>(url);
  }
}
