import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../../base.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ChargeTypesService extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  getData<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
    Observable<ApiResult> {
    var url = this.baseUrl + 'api/chargeTypes';
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

  get<ChargeType>(id): Observable<ChargeType> {
    var url = this.baseUrl + "api/chargeTypes/" + id;
    return this.http.get<ChargeType>(url);
  }

  put<ChargeType>(item): Observable<ChargeType> {
    var url = this.baseUrl + "api/chargeTypes/" + item.chargeTypeId;
    return this.http.put<ChargeType>(url, item);
  }

  post<ChargeType>(item): Observable<ChargeType> {
    var url = this.baseUrl + "api/chargeTypes/";
    return this.http.post<ChargeType>(url, item);
  }

  delete<ChargeType>(id): Observable<ChargeType> {
    var url = this.baseUrl + "api/chargeTypes/" + id;
    return this.http.delete<ChargeType>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + "api/chargeTypes/IsDuplicate";
    return this.http.post<boolean>(url, item);
  }

}
