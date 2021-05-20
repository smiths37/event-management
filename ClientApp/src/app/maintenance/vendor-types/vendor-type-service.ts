import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../../base.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class VendorTypeService extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  getData<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
    Observable<ApiResult> {
    var url = this.baseUrl + 'api/vendorTypes';
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

  get<VendorType>(id): Observable<VendorType> {
    var url = this.baseUrl + "api/vendorTypes/" + id;
    return this.http.get<VendorType>(url);
  }

  put<VendorType>(item): Observable<VendorType> {
    var url = this.baseUrl + "api/vendorTypes/" + item.vendorTypeId;
    return this.http.put<VendorType>(url, item);
  }

  post<VendorType>(item): Observable<VendorType> {
    var url = this.baseUrl + "api/vendorTypes/";
    return this.http.post<VendorType>(url, item);
  }

  delete<VendorType>(id): Observable<VendorType> {
    var url = this.baseUrl + "api/vendorTypes/" + id;
    return this.http.delete<VendorType>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + "api/vendorTypes/IsDuplicate";
    return this.http.post<boolean>(url, item);
  }

}
