import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../../base.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class RoomSetupTypeService extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  getData<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
    Observable<ApiResult> {
    var url = this.baseUrl + 'api/roomSetups';
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

  get<RoomSetup>(id): Observable<RoomSetup> {
    var url = this.baseUrl + "api/roomSetups/" + id;
    return this.http.get<RoomSetup>(url);
  }

  put<RoomSetup>(item): Observable<RoomSetup> {
    var url = this.baseUrl + "api/roomSetups/" + item.setupId;
    return this.http.put<RoomSetup>(url, item);
  }

  post<RoomSetup>(item): Observable<RoomSetup> {
    var url = this.baseUrl + "api/roomSetups/";
    return this.http.post<RoomSetup>(url, item);
  }

  delete<RoomSetup>(id): Observable<RoomSetup> {
    var url = this.baseUrl + "api/roomSetups/" + id;
    return this.http.delete<RoomSetup>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + "api/roomSetups/IsDuplicate";
    return this.http.post<boolean>(url, item);
  }

}
