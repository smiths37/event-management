import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../../base.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class ContactTypeService extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  getData<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
    Observable<ApiResult> {
    var url = this.baseUrl + 'api/contactTypes';
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

  get<ContactType>(id): Observable<ContactType> {
    var url = this.baseUrl + "api/contactTypes/" + id;
    return this.http.get<ContactType>(url);
  }

  put<ContactType>(item): Observable<ContactType> {
    var url = this.baseUrl + "api/contactTypes/" + item.contactTypeId;
    return this.http.put<ContactType>(url, item);
  }

  post<ContactType>(item): Observable<ContactType> {
    var url = this.baseUrl + "api/contactTypes/";
    return this.http.post<ContactType>(url, item);
  }

  delete<ContactType>(id): Observable<ContactType> {
    var url = this.baseUrl + "api/contactTypes/" + id;
    return this.http.delete<ContactType>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + "api/contactTypes/IsDuplicate";
    return this.http.post<boolean>(url, item);
  }

}
