import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../../base.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class FBItemsService extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  getData<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
    Observable<ApiResult> {
    var url = this.baseUrl + 'api/FoodAndBeverage';
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

  get<FbItem>(id): Observable<FbItem> {
    var url = this.baseUrl + "api/FoodAndBeverage/" + id;
    return this.http.get<FbItem>(url);
  }

  put<FbItem>(item): Observable<FbItem> {
    var url = this.baseUrl + "api/FoodAndBeverage/" + item.fbId;
    return this.http.put<FbItem>(url, item);
  }

  post<FbItem>(item): Observable<FbItem> {
    var url = this.baseUrl + "api/FoodAndBeverage/";
    return this.http.post<FbItem>(url, item);
  }

  delete<FbItem>(id): Observable<FbItem> {
    var url = this.baseUrl + "api/FoodAndBeverage/" + id;
    return this.http.delete<FbItem>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + "api/FoodAndBeverage/IsDuplicate";
    return this.http.post<boolean>(url, item);
  }

}
