import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../base.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class MeetingService extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  //Get all meetings
  getData<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
    Observable<ApiResult> {
    var url = this.baseUrl + 'api/meetings';
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

  //Get only meetings happening now or in the future
  getCurrentMeetings<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
  Observable<ApiResult> {
    var url = this.baseUrl + 'api/meetings';
    var params = new HttpParams()
      .set("pageIndex", pageIndex.toString())
      .set("pageSize", pageSize.toString())
      .set("sortColumn", sortColumn.toString())
      .set("sortOrder", sortOrder.toString())
      .set("criteria", "currentMeetings")
    if (filterQuery) {
      params = params
        .set("filterColumn", filterColumn.toString())
        .set("filterQuery", filterQuery.toString())
    }
    return this.http.get<ApiResult>(url, { params });
  }

  get<Meeting>(id): Observable<Meeting> {
    var url = this.baseUrl + "api/meetings/" + id;
    return this.http.get<Meeting>(url);
  }

  put<Meeting>(item): Observable<Meeting> {
    var url = this.baseUrl + "api/meetings/" + item.meetingId;
    return this.http.put<Meeting>(url, item);
  }

  post<Meeting>(item): Observable<Meeting> {
    var url = this.baseUrl + "api/meetings/";
    return this.http.post<Meeting>(url, item);
  }

  delete<Meeting>(id): Observable<Meeting> {
    var url = this.baseUrl + "api/meetings/" + id;
    return this.http.delete<Meeting>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + "api/meetings/IsDuplicate";
    return this.http.post<boolean>(url, item);
  }

}
