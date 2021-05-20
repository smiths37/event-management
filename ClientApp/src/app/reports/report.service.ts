import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../base.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ReportService extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  //Get all meetings
  getData<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
    Observable<ApiResult> {
    var url = this.baseUrl + 'api/Reports';
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

//The rest of these will never be used, but they are required by the Base Service
  get<Report>(id): Observable<Report> {
    var url = this.baseUrl + "api/Reports/" + id;
    return this.http.get<Report>(url);
  }

  put<Report>(item): Observable<Report> {
    var url = this.baseUrl + "api/Reports/" + item.reportId;
    return this.http.put<Report>(url, item);
  }

  post<Report>(item): Observable<Report> {
    var url = this.baseUrl + "api/Reports/";
    return this.http.post<Report>(url, item);
  }

  delete<Report>(id): Observable<Report> {
    var url = this.baseUrl + "api/Reports/" + id;
    return this.http.delete<Report>(url);
  }

}
