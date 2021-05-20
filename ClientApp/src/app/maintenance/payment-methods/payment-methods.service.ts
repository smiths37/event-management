import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../../base.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class PaymentMethodService extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  getData<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
    Observable<ApiResult> {
    var url = this.baseUrl + 'api/paymentMethods';
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

  get<PaymentMethod>(id): Observable<PaymentMethod> {
    var url = this.baseUrl + "api/paymentMethods/" + id;
    return this.http.get<PaymentMethod>(url);
  }

  put<PaymentMethod>(item): Observable<PaymentMethod> {
    var url = this.baseUrl + "api/paymentMethods/" + item.paymentMethodId;
    return this.http.put<PaymentMethod>(url, item);
  }

  post<PaymentMethod>(item): Observable<PaymentMethod> {
    var url = this.baseUrl + "api/paymentMethods/";
    return this.http.post<PaymentMethod>(url, item);
  }

  delete<PaymentMethod>(id): Observable<PaymentMethod> {
    var url = this.baseUrl + "api/paymentMethods/" + id;
    return this.http.delete<PaymentMethod>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + "api/paymentMethods/IsDuplicate";
    return this.http.post<boolean>(url, item);
  }

}
