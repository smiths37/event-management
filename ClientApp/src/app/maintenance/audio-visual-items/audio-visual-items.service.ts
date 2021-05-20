import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';
import { BaseService, ApiResult } from '../../base.service';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class AudioVisualItemsService extends BaseService {
  constructor(
    http: HttpClient,
    @Inject('BASE_URL') baseUrl: string) {
    super(http, baseUrl);
  }

  getData<ApiResult>(pageIndex: number, pageSize: number, sortColumn: string, sortOrder: string, filterColumn: string, filterQuery: string):
    Observable<ApiResult> {
    var url = this.baseUrl + 'api/AudioVisualItems';
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

  get<AudioVisualItem>(id): Observable<AudioVisualItem> {
    var url = this.baseUrl + "api/AudioVisualItems/" + id;
    return this.http.get<AudioVisualItem>(url);
  }

  put<AudioVisualItem>(item): Observable<AudioVisualItem> {
    var url = this.baseUrl + "api/AudioVisualItems/" + item.avId;
    return this.http.put<AudioVisualItem>(url, item);
  }

  post<AudioVisualItem>(item): Observable<AudioVisualItem> {
    var url = this.baseUrl + "api/AudioVisualItems/";
    return this.http.post<AudioVisualItem>(url, item);
  }

  delete<AudioVisualItem>(id): Observable<AudioVisualItem> {
    var url = this.baseUrl + "api/AudioVisualItems/" + id;
    return this.http.delete<AudioVisualItem>(url);
  }

  isDuplicate(item): Observable<boolean> {
    var url = this.baseUrl + "api/AudioVisualItems/IsDuplicate";
    return this.http.post<boolean>(url, item);
  }

}
