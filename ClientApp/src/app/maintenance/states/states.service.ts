import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../../base.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class StateService extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  getData<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
    Observable<ApiResult> {
    var url = this.baseUrl + 'api/states';
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

  get<State>(id): Observable<State> {
    var url = this.baseUrl + "api/states/" + id;
    return this.http.get<State>(url);
  }

  put<State>(item): Observable<State> {
    var url = this.baseUrl + "api/states/" + item.stateCode;
    return this.http.put<State>(url, item);
  }

  post<State>(item): Observable<State> {
    var url = this.baseUrl + "api/states/";
    return this.http.post<State>(url, item);
  }

  delete<State>(id): Observable<State> {
    var url = this.baseUrl + "api/states/" + id;
    return this.http.delete<State>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + "api/states/IsDuplicate";
    return this.http.post<boolean>(url, item);
  }

}
