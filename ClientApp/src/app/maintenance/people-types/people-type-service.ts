import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../../base.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class PeopleTypeService extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  getData<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
    Observable<ApiResult> {
    var url = this.baseUrl + 'api/peopleTypes';
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

  get<PeopleType>(id): Observable<PeopleType> {
    var url = this.baseUrl + "api/peopleTypes/" + id;
    return this.http.get<PeopleType>(url);
  }

  put<PeopleType>(item): Observable<PeopleType> {
    var url = this.baseUrl + "api/peopleTypes/" + item.peopleTypeId;
    return this.http.put<PeopleType>(url, item);
  }

  post<PeopleType>(item): Observable<PeopleType> {
    var url = this.baseUrl + "api/peopleTypes/";
    return this.http.post<PeopleType>(url, item);
  }

  delete<PeopleType>(id): Observable<PeopleType> {
    var url = this.baseUrl + "api/peopleTypes/" + id;
    return this.http.delete<PeopleType>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + "api/peopleTypes/IsDuplicate";
    return this.http.post<boolean>(url, item);
  }

}
