 import { Component, OnInit, Inject, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
//import { HttpClient, HttpParams } from '@angular/common/http';

import { ContactType } from './contact-type';
import { ContactTypeService } from './contact-types.service';
import { ApiResult } from '../../base.service'

@Component({
  selector: 'app-contact-types',
  templateUrl: './contact-types.component.html',
  styleUrls: ['./contact-types.component.css', '../../../global.css']
})
export class ContactTypesComponent implements OnInit {
  public displayColumns: string[] = ['contactTypeId', 'contactTypeDesc'];
  public contactTypes: MatTableDataSource<ContactType>;

  defaultPageIndex: number = 0;
  defaultPageSize: number = 100;
  public defaultSortColumn: string = "contactTypeDesc";
  public defaultSortOrder: string = "asc";

  defaultFilterColumn: string = "contactTypeDesc";
  filterQuery: string = null;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: false }) sort: MatSort;

  constructor(
    //private http: HttpClient,
    //@Inject('BASE_URL') private baseUrl: string
    private contactTypeService: ContactTypeService
  ) {  }

  ngOnInit() {
    this.loadData();
  }

  loadData(query: string = null) {
    var pageEvent = new PageEvent();
    pageEvent.pageIndex = this.defaultPageIndex;
    pageEvent.pageSize = this.defaultPageSize;
    this.getData(pageEvent);

    if (query) {
      this.filterQuery = query;
    }
  }

  getData(event: PageEvent) {
    //var url = this.baseUrl + "api/contactTypes";
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

    this.contactTypeService.getData<ApiResult<ContactType>>(event.pageIndex, event.pageSize, sortColumn, sortOrder, filterColumn, filterQuery)
      .subscribe(result => {
        this.paginator.length = result.totalCount;
        this.paginator.pageIndex = result.pageIndex;
        this.paginator.pageSize = result.pageSize;
        this.contactTypes = new MatTableDataSource<ContactType>(result.data);
      }, error => console.error(error));
  }

}
