import { Component, OnInit, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
//import { HttpClient, HttpParams } from '@angular/common/http';

import { State } from './state';
import { StateService } from './states.service';
import { ApiResult } from '../../base.service'

@Component({
  selector: 'app-states',
  templateUrl: './states.component.html',
  styleUrls: ['./states.component.css', '../../../global.css']
})
export class StatesComponent implements OnInit {
  public displayColumns: string[] = ['stateCode', 'stateName'];
  public states: MatTableDataSource<State>;

  defaultPageIndex: number = 0;
  defaultPageSize: number = 100;
  public defaultSortColumn: string = "stateCode";
  public defaultSortOrder: string = "asc";

  defaultFilterColumn: string = "stateName";
  filterQuery: string = null;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: false }) sort: MatSort;

  constructor(private stateService: StateService) { }

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

    this.stateService.getData<ApiResult<State>>(event.pageIndex, event.pageSize, sortColumn, sortOrder, filterColumn, filterQuery)
      .subscribe(result => {
        this.paginator.length = result.totalCount;
        this.paginator.pageIndex = result.pageIndex;
        this.paginator.pageSize = result.pageSize;
        this.states = new MatTableDataSource<State>(result.data);
      }, error => console.error(error));
  }
}
