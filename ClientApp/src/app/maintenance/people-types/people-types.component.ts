import { Component, OnInit, Inject, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
//import { HttpClient, HttpParams } from '@angular/common/http';

import { PeopleType } from './people-type';
import { PeopleTypeService } from './people-type-service';
import { ApiResult } from '../../base.service'

@Component({
  selector: 'app-people-types',
  templateUrl: './people-types.component.html',
  styleUrls: ['./people-types.component.css', '../../../global.css']
})
export class PeopleTypesComponent implements OnInit {
  public displayColumns: string[] = ['peopleTypeId', 'peopleTypeDesc'];
  public peopleTypes: MatTableDataSource<PeopleType>;

  defaultPageIndex: number = 0;
  defaultPageSize: number = 100;
  public defaultSortColumn: string = "peopleTypeDesc";
  public defaultSortOrder: string = "asc";

  defaultFilterColumn: string = "peopleTypeDesc";
  filterQuery: string = null;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: false }) sort: MatSort;

  constructor(private peopleTypeService: PeopleTypeService) { }

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
    var sortColumn = (this.sort) ? this.sort.active : this.defaultSortColumn;
    var sortOrder = (this.sort) ? this.sort.direction : this.defaultSortOrder;
    var filterColumn = (this.filterQuery) ? this.defaultFilterColumn : null;
    var filterQuery = (this.filterQuery) ? this.filterQuery : null;

    this.peopleTypeService.getData<ApiResult<PeopleType>>(event.pageIndex, event.pageSize, sortColumn, sortOrder, filterColumn, filterQuery)
      .subscribe(result => {
        this.paginator.length = result.totalCount;
        this.paginator.pageIndex = result.pageIndex;
        this.paginator.pageSize = result.pageSize;
        this.peopleTypes = new MatTableDataSource<PeopleType>(result.data);
      }, error => console.error(error));
  }

}
