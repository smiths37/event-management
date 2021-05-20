import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../../base.service';
import { Observable } from 'rxjs';
import { getBaseUrl } from '../../../main';
import { Company } from '../../companies/company';

@Injectable({
  providedIn: 'root',
})

export class CompanyTypeService
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
    filterQuery: string): Observable<ApiResult> {
    var url = this.baseUrl + 'api/CompanyTypes';
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
  
  get<CompanyType>(CompanyTypeId): Observable<CompanyType> {
    var url = this.baseUrl + 'api/CompanyTypes/' + CompanyTypeId;
    return this.http.get<CompanyType>(url);
  }

  put<CompanyType>(item): Observable<CompanyType> {
    var url = this.baseUrl + 'api/CompanyTypes/' + item.companyTypeId;
    return this.http.put<CompanyType>(url, item);
  }

  post<CompanyType>(item): Observable<CompanyType> {
    var url = this.baseUrl + 'api/CompanyTypes/';
    return this.http.post<CompanyType>(url, item);
  }

  delete<CompanyType>(id): Observable<CompanyType> {
    var url = this.baseUrl + "api/CompanyTypes/" + id;
    return this.http.delete<CompanyType>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + "api/CompanyTypes/IsDuplicate";
    return this.http.post<boolean>(url, item);
  }

    //getCountries<ApiResult>(
  //  pageIndex: number,
  //  pageSize: number,
  //  sortColumn: string,
  //  sortOrder: string,
  //  filterColumn: string,
  //  filterQuery: string
  //): Observable<ApiResult> {
  //  var url = this.baseUrl + 'api/Countries';
  //  var params = new HttpParams()
  //    .set("pageIndex", pageIndex.toString())
  //    .set("pageSize", pageSize.toString())
  //    .set("sortColumn", sortColumn)
  //    .set("sortOrder", sortOrder);

  //  if (filterQuery) {
  //    params = params
  //      .set("filterColumn", filterColumn)
  //      .set("filterQuery", filterQuery);
  //  }

  //  return this.http.get<ApiResult>(url, { params });
  //}
}
