import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../../base.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class SpeakerTypeService extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  getData<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
    Observable<ApiResult> {
    var url = this.baseUrl + 'api/speakerTypes';
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

  get<SpeakerType>(id): Observable<SpeakerType> {
    var url = this.baseUrl + "api/speakerTypes/" + id;
    return this.http.get<SpeakerType>(url);
  }

  put<SpeakerType>(item): Observable<SpeakerType> {
    var url = this.baseUrl + "api/speakerTypes/" + item.speakerTypeId;
    return this.http.put<SpeakerType>(url, item);
  }

  post<SpeakerType>(item): Observable<SpeakerType> {
    var url = this.baseUrl + "api/speakerTypes/";
    return this.http.post<SpeakerType>(url, item);
  }

  delete<SpeakerType>(id): Observable<SpeakerType> {
    var url = this.baseUrl + "api/speakerTypes/" + id;
    return this.http.delete<SpeakerType>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + "api/speakerTypes/IsDuplicate";
    return this.http.post<boolean>(url, item);
  }

}
