import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../base.service';
import { Observable } from 'rxjs';
import { PersonNote } from './person-note';

@Injectable({
  providedIn: 'root',
})
export class PersonNoteService
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

  get<PersonNote>(noteId): Observable<PersonNote> {
    var url = this.baseUrl + "api/Notes/" + noteId;
    return this.http.get<PersonNote>(url);
  }

  put<PersonNote>(item): Observable<PersonNote> {
    var url = this.baseUrl + 'api/Notes/' + item.noteId;
    return this.http.put<PersonNote>(url, item);
  }

  post<PersonNote>(item): Observable<PersonNote> {
    var url = this.baseUrl + 'api/Notes/';
    return this.http.post<PersonNote>(url, item);
  }

  delete<PersonNote>(noteId): Observable<PersonNote> {
    var url = this.baseUrl + "api/Notes/" + noteId;
    return this.http.delete<PersonNote>(url);
  }
}
