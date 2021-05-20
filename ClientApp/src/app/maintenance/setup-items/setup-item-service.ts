import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../../base.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class SetupItemService extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  getData<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
    Observable<ApiResult> {
    var url = this.baseUrl + 'api/setupItems';
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

  get<SetupItem>(id): Observable<SetupItem> {
    var url = this.baseUrl + "api/setupItems/" + id;
    return this.http.get<SetupItem>(url);
  }

  put<SetupItem>(item): Observable<SetupItem> {
    var url = this.baseUrl + "api/setupItems/" + item.setupId;
    return this.http.put<SetupItem>(url, item);
  }

  post<SetupItem>(item): Observable<SetupItem> {
    var url = this.baseUrl + "api/setupItems/";
    return this.http.post<SetupItem>(url, item);
  }

  delete<SetupItem>(id): Observable<SetupItem> {
    var url = this.baseUrl + "api/setupItems/" + id;
    return this.http.delete<SetupItem>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + "api/setupItems/IsDuplicate";
    return this.http.post<boolean>(url, item);
  }

}
