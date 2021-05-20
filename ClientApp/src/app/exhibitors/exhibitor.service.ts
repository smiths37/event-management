import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../base.service';
import { Observable } from 'rxjs';
import { Exhibitor } from '../exhibitors/exhibitor';

@Injectable({
  providedIn: 'root',
})
export class ExhibitorService
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
    var url = this.baseUrl + 'api/Exhibitors';
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

  //not used
  get<Exhibitor>(companyId): Observable<Exhibitor> {
    var url = this.baseUrl + "api/Exhibitors/" + companyId;
    return this.http.get<Exhibitor>(url);
  }

  getExhibitorByCompanyAndMeeting<Exhibitor>(companyId, meetingCode): Observable<Exhibitor> {
    var url = this.baseUrl + "api/Exhibitors/" + companyId + "/" + meetingCode;
    return this.http.get<Exhibitor>(url);
  }

  put<Exhibitor>(item): Observable<Exhibitor> {
    var url = this.baseUrl + 'api/Exhibitors/' + item.companyId + "/" + item.meetingCode;
    return this.http.put<Exhibitor>(url, item);
  }

  post<Exhibitor>(item): Observable<Exhibitor> {
    var url = this.baseUrl + 'api/Exhibitors/';
    return this.http.post<Exhibitor>(url, item);
  }

  //Not used
  delete<Exhibitor>(exhibitorId): Observable<Exhibitor> {
    var url = this.baseUrl + "api/Exhibitors/" + exhibitorId;
    return this.http.delete<Exhibitor>(url);
  }

  deleteExhibitorByCompanyAndMeeting<Exhibitor>(companyId, meetingCode): Observable<Exhibitor> {
    var url = this.baseUrl + "api/Exhibitors/" + companyId + "/" + meetingCode;
    return this.http.delete<Exhibitor>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + "api/Exhibitors/IsDuplicate";
    return this.http.post<boolean>(url, item);
  }
}
