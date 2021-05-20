import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../../base.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class GuestTypeService extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  getData<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
    Observable<ApiResult> {
    var url = this.baseUrl + 'api/guestTypes';
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

  get<GuestType>(id): Observable<GuestType> {
    var url = this.baseUrl + "api/guestTypes/" + id;
    return this.http.get<GuestType>(url);
  }

  put<GuestType>(item): Observable<GuestType> {
    var url = this.baseUrl + "api/guestTypes/" + item.guestTypeId;
    return this.http.put<GuestType>(url, item);
  }

  post<GuestType>(item): Observable<GuestType> {
    var url = this.baseUrl + "api/guestTypes/";
    return this.http.post<GuestType>(url, item);
  }

  delete<GuestType>(id): Observable<GuestType> {
    var url = this.baseUrl + "api/guestTypes/" + id;
    return this.http.delete<GuestType>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + "api/guestTypes/IsDuplicate";
    return this.http.post<boolean>(url, item);
  }

}
