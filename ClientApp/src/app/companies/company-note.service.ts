import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../base.service';
import { Observable } from 'rxjs';
import { CompanyNote } from './company-note';

@Injectable({
  providedIn: 'root',
})
export class CompanyNoteService
  extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  //This would get all notes, for companies, meetings, people, etc. - we don't need this for the actual application, but the BaseService requires it
  getData<ApiResult>(
    pageIndex: number,
    pageSize: number,
    sortColumn: string,
    sortOrder: string,
    filterColumn: string,
    filterQuery: string
  ): Observable<ApiResult> {
    var url = this.baseUrl + 'api/Notes';
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

  get<CompanyNote>(noteId): Observable<CompanyNote> {
    var url = this.baseUrl + "api/Notes/" + noteId;
    return this.http.get<CompanyNote>(url);
  }

  put<CompanyNote>(item): Observable<CompanyNote> {
    var url = this.baseUrl + 'api/Notes/' + item.noteId;
    return this.http.put<CompanyNote>(url, item);
  }

  post<CompanyNote>(item): Observable<CompanyNote> {
    var url = this.baseUrl + 'api/Notes/';
    return this.http.post<CompanyNote>(url, item);
  }

  delete<CompanyNote>(noteId): Observable<CompanyNote> {
    var url = this.baseUrl + "api/Notes/" + noteId;
    return this.http.delete<CompanyNote>(url);
  }
}
