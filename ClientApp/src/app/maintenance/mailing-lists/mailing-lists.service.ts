import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../../base.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class MailingListService extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  getData<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
    Observable<ApiResult> {
    var url = this.baseUrl + 'api/Lists';
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

  get<MailingLists>(id): Observable<MailingLists> {
    var url = this.baseUrl + "api/Lists/" + id;
    return this.http.get<MailingLists>(url);
  }

  put<MailingLists>(item): Observable<MailingLists> {
    var url = this.baseUrl + "api/Lists/" + item.listCode;
    return this.http.put<MailingLists>(url, item);
  }

  post<MailingLists>(item): Observable<MailingLists> {
    var url = this.baseUrl + "api/Lists/";
    return this.http.post<MailingLists>(url, item);
  }

  delete<MailingLists>(id): Observable<MailingLists> {
    var url = this.baseUrl + "api/Lists/" + id;
    return this.http.delete<MailingLists>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + "api/Lists/IsDuplicate";
    return this.http.post<boolean>(url, item);
  }

}
