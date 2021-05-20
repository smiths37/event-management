import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../../base.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AddressTypeService extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  getData<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
    Observable<ApiResult> {
    var url = this.baseUrl + 'api/addressTypes';
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

  get<AddressType>(id): Observable<AddressType> {
    var url = this.baseUrl + "api/addressTypes/" + id;
    return this.http.get<AddressType>(url);
  }

  put<AddressType>(item): Observable<AddressType> {
    var url = this.baseUrl + "api/addressTypes/" + item.addressTypeId;
    return this.http.put<AddressType>(url, item);
  }

  post<AddressType>(item): Observable<AddressType> {
    var url = this.baseUrl + "api/addressTypes/";
    return this.http.post<AddressType>(url, item);
  }

  delete<AddressType>(id): Observable<AddressType> {
    var url = this.baseUrl + "api/addressTypes/" + id;
    return this.http.delete<AddressType>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + "api/addressTypes/IsDuplicate";
    return this.http.post<boolean>(url, item);
  }

}
