import { Component, OnInit, Inject, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
//import { HttpClient, HttpParams } from '@angular/common/http';

import { GuestType } from './guest-type';
import { GuestTypeService } from './guest-type.service'
import { ApiResult } from '../../base.service'

@Component({
  selector: 'app-guest-types',
  templateUrl: './guest-types.component.html',
  styleUrls: ['./guest-types.component.css', '../../../global.css']
})
export class GuestTypesComponent implements OnInit {
  public displayColumns: string[] = ['guestTypeId', 'guestTypeDesc'];
  public guestTypes: MatTableDataSource<GuestType>;

  defaultPageIndex: number = 0;
  defaultPageSize: number = 100;
  public defaultSortColumn: string = "guestTypeDesc";
  public defaultSortOrder: string = "asc";

  defaultFilterColumn: string = "guestTypeDesc";
  filterQuery: string = null;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: false }) sort: MatSort;

  //constructor(
  //  private http: HttpClient,
  //  @Inject('BASE_URL') private baseUrl: string) {
  //}

  constructor(
    private guestTypeService: GuestTypeService
  ) { }

  ngOnInit() {
    this.loadData();
  }

  loadData(query: string = null) {
    var pageEvent = new PageEvent();
    pageEvent.pageIndex = this.defaultPageIndex;
    pageEvent.pageSize = this.defaultPageSize;

    if (query) {
      this.filterQuery = query;
    }

    this.getData(pageEvent);
  }

  getData(event: PageEvent) {
    //var url = this.baseUrl + "api/guestTypes";
    //var params = new HttpParams()
    //  .set("pageIndex", event.pageIndex.toString())
    //  .set("pageSize", event.pageSize.toString())
    //  .set("sortColumn", (this.sort) ? this.sort.active : this.defaultSortColumn)
    //  .set("sortOrder", (this.sort) ? this.sort.direction : this.defaultSortOrder);

    //if (this.filterQuery) {
    //  params = params
    //    .set("filterColumn", this.defaultFilterColumn)
    //    .set("filterquery", this.filterQuery);
    //}


    //this.http.get<any>(url, { params })

    var sortColumn = (this.sort) ? this.sort.active : this.defaultSortColumn;
    var sortOrder = (this.sort) ? this.sort.direction : this.defaultSortOrder;
    var filterColumn = (this.filterQuery) ? this.defaultFilterColumn : null;
    var filterQuery = (this.filterQuery) ? this.filterQuery : null;

    this.guestTypeService.getData<ApiResult<GuestType>>(event.pageIndex, event.pageSize, sortColumn, sortOrder, filterColumn, filterQuery)
      .subscribe(result => {
        this.paginator.length = result.totalCount;
        this.paginator.pageIndex = result.pageIndex;
        this.paginator.pageSize = result.pageSize;
        this.guestTypes = new MatTableDataSource<GuestType>(result.data);
      }, error => console.error(error));
  }

}
