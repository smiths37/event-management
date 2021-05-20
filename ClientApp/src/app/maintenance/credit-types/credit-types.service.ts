import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../../base.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class CreditTypeService extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  getData<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
    Observable<ApiResult> {
    var url = this.baseUrl + 'api/creditTypes';
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

  get<CreditType>(id): Observable<CreditType> {
    var url = this.baseUrl + "api/creditTypes/" + id;
    return this.http.get<CreditType>(url);
  }

  put<CreditType>(item): Observable<CreditType> {
    var url = this.baseUrl + "api/creditTypes/" + item.creditTypeCode;
    return this.http.put<CreditType>(url, item);
  }

  post<CreditType>(item): Observable<CreditType> {
    var url = this.baseUrl + "api/creditTypes/";
    return this.http.post<CreditType>(url, item);
  }

  delete<CreditType>(id): Observable<CreditType> {
    var url = this.baseUrl + "api/creditTypes/" + id;
    return this.http.delete<CreditType>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + "api/creditTypes/IsDuplicate";
    return this.http.post<boolean>(url, item);
  }

}
