import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../../base.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class SourceTypeService extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  getData<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
    Observable<ApiResult> {
    var url = this.baseUrl + 'api/Sources';
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

  get<Source>(id): Observable<Source> {
    var url = this.baseUrl + "api/Sources/" + id;
    return this.http.get<Source>(url);
  }

  put<Source>(item): Observable<Source> {
    var url = this.baseUrl + "api/Sources/" + item.sourceId;
    return this.http.put<Source>(url, item);
  }

  post<Source>(item): Observable<Source> {
    var url = this.baseUrl + "api/Sources/";
    return this.http.post<Source>(url, item);
  }

  delete<Source>(id): Observable<Source> {
    var url = this.baseUrl + "api/Sources/" + id;
    return this.http.delete<Source>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + "api/Sources/IsDuplicate";
    return this.http.post<boolean>(url, item);
  }

}
