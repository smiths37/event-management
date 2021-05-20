import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../base.service';
import { Observable } from 'rxjs';
import { CompanyAddress } from './company-address';

@Injectable({
  providedIn: 'root',
})
export class CompanyService
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
    var url = this.baseUrl + 'api/Companies';
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

  get<Company>(CompanyId): Observable<Company> {
    var url = this.baseUrl + "api/Companies/" + CompanyId;
    return this.http.get<Company>(url);
  }

  put<Company>(item): Observable<Company> {
    var url = this.baseUrl + 'api/Companies/' + item.companyId;
    return this.http.put<Company>(url, item);
  }

  post<Company>(item): Observable<Company> {
    var url = this.baseUrl + 'api/Companies/';
    return this.http.post<Company>(url, item);
  }

  delete<Company>(id): Observable<Company> {
    var url = this.baseUrl + "api/Companies/" + id;
    return this.http.delete<Company>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + 'api/Companies/IsDuplicate';
    return this.http.post<boolean>(url, item);
  }

  //getAddresses(id): Observable<List<CompanyAddress>> {
  //  var url = this.baseUrl + "api/Companies/GetAddresses/" + id;
  //  return this.http.post<CompanyAddress>(url, null, null);
  //}
}
