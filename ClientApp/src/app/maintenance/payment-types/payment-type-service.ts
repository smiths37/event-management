import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../../base.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class PaymentTypeService extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  getData<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
    Observable<ApiResult> {
    var url = this.baseUrl + 'api/paymentTypes';
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

  get<PaymentType>(id): Observable<PaymentType> {
    var url = this.baseUrl + "api/paymentTypes/" + id;
    return this.http.get<PaymentType>(url);
  }

  put<PaymentType>(item): Observable<PaymentType> {
    var url = this.baseUrl + "api/paymentTypes/" + item.paymentTypeId;
    return this.http.put<PaymentType>(url, item);
  }

  post<PaymentType>(item): Observable<PaymentType> {
    var url = this.baseUrl + "api/paymentTypes/";
    return this.http.post<PaymentType>(url, item);
  }

  delete<PaymentType>(id): Observable<PaymentType> {
    var url = this.baseUrl + "api/paymentTypes/" + id;
    return this.http.delete<PaymentType>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + "api/paymentTypes/IsDuplicate";
    return this.http.post<boolean>(url, item);
  }

}
