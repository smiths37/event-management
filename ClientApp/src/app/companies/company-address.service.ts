import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../base.service';
import { Observable } from 'rxjs';
import { CompanyAddress } from './company-address';

@Injectable({
  providedIn: 'root',
})
export class CompanyAddressService
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
    var url = this.baseUrl + 'api/CompanyAddresses';
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
    var url = this.baseUrl + 'api/CompanyAddresses';
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

  get<CompanyAddress>(id): Observable<CompanyAddress> {
    var url = this.baseUrl + "api/CompanyAddresses/" + id;
    return this.http.get<CompanyAddress>(url);
  }

  put<CompanyAddress>(item): Observable<CompanyAddress> {
    var url = this.baseUrl + 'api/CompanyAddresses/' + item.addressId;
    return this.http.put<CompanyAddress>(url, item);
  }

  post<CompanyAddress>(item): Observable<CompanyAddress> {
    var url = this.baseUrl + 'api/CompanyAddresses/';
    return this.http.post<CompanyAddress>(url, item);
  }

  delete<CompanyAddress>(id): Observable<CompanyAddress> {
    var url = this.baseUrl + "api/CompanyAddresses/" + id;
    return this.http.delete<CompanyAddress>(url);
  }

  //isDuplicate(item): Observable<boolean> {
  //  var url = this.baseUrl + 'api/Companies/IsDupeCity';
  //  return this.http.post<boolean>(url, item);
  //}

}
