import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../base.service';
import { Observable } from 'rxjs';
import { PersonAddress } from './person-address';

@Injectable({
  providedIn: 'root',
})
export class PersonAddressService
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
    var url = this.baseUrl + 'api/PeopleAddresses';
    var params = new HttpParams()
      .set("pageIndex", pageIndex.toString())
      .set("pageSize", pageSize.toString())
      .set("sortColumn", sortColumn)
      .set("sortOrder", sortOrder);

    if (filterQuery) {
      params = params
        .set("filterColumn", filterColumn)
        .set("filterQuery", filterQuery);

      console.log("url with params: " + url);
    }

    return this.http.get<ApiResult>(url, { params });
  }

  getCompanyAddresses<ApiResult>(pageIndex: number,
    pageSize: number,
    sortColumn: string,
    sortOrder: string,
    filterColumn: string,
    filterQuery: number): Observable<ApiResult> {
    var url = this.baseUrl + 'api/PeopleAddresses';
    var params = new HttpParams()
      .set("pageIndex", pageIndex.toString())
      .set("pageSize", pageSize.toString())
      .set("sortColumn", sortColumn)
      .set("sortOrder", sortOrder);

    if (filterQuery) {
      params = params
        .set("filterColumn", filterColumn)
        .set("filterQuery", filterQuery.toString());
    }

    return this.http.get<ApiResult>(url, { params });
  }

  get<PersonAddress>(id): Observable<PersonAddress> {
    var url = this.baseUrl + "api/PeopleAddresses/" + id;
    return this.http.get<PersonAddress>(url);
  }

  put<PersonAddress>(item): Observable<PersonAddress> {
    var url = this.baseUrl + 'api/PeopleAddresses/' + item.addressId;
    return this.http.put<PersonAddress>(url, item);
  }

  post<PersonAddress>(item): Observable<PersonAddress> {
    var url = this.baseUrl + 'api/PeopleAddresses/';
    return this.http.post<PersonAddress>(url, item);
  }

  delete<PersonAddress>(id): Observable<PersonAddress> {
    var url = this.baseUrl + "api/PeopleAddresses/" + id;
    return this.http.delete<PersonAddress>(url);
  }

  //isDuplicate(item): Observable<boolean> {
  //  var url = this.baseUrl + 'api/Companies/IsDupeCity';
  //  return this.http.post<boolean>(url, item);
  //}

}
