import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../../base.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class EmailTypeService extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  getData<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
    Observable<ApiResult> {
    var url = this.baseUrl + 'api/emailTypes';
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

  get<EmailType>(id): Observable<EmailType> {
    var url = this.baseUrl + "api/emailTypes/" + id;
    return this.http.get<EmailType>(url);
  }

  put<EmailType>(item): Observable<EmailType> {
    var url = this.baseUrl + "api/emailTypes/" + item.emailTypeId;
    return this.http.put<EmailType>(url, item);
  }

  post<EmailType>(item): Observable<EmailType> {
    var url = this.baseUrl + "api/emailTypes/";
    return this.http.post<EmailType>(url, item);
  }

  delete<EmailType>(id): Observable<EmailType> {
    var url = this.baseUrl + "api/emailTypes/" + id;
    return this.http.delete<EmailType>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + "api/emailTypes/IsDuplicate";
    return this.http.post<boolean>(url, item);
  }

}
