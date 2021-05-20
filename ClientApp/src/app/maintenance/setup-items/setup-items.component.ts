import { Component, OnInit, Inject, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';

import { SetupItem } from './setup-item';
import { SetupItemService } from './setup-item-service';
import { ApiResult } from '../../base.service'

@Component({
  selector: 'app-setup-items',
  templateUrl: './setup-items.component.html',
  styleUrls: ['./setup-items.component.css', '../../../global.css']
})
export class SetupItemsComponent implements OnInit {

  public displayColumns: string[] = ['setupId', 'setupDesc'];
  public setupItems: MatTableDataSource<SetupItem>;

  defaultPageIndex: number = 0;
  defaultPageSize: number = 100;
  public defaultSortColumn: string = "setupDesc";
  public defaultSortOrder: string = "asc";

  defaultFilterColumn: string = "setupDesc";
  filterQuery: string = null;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: false }) sort: MatSort;

  constructor(private setupItemService: SetupItemService) { }

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

    this.setupItemService.getData<ApiResult<SetupItem>>(event.pageIndex, event.pageSize, sortColumn, sortOrder, filterColumn, filterQuery)
      .subscribe(result => {
        this.paginator.length = result.totalCount;
        this.paginator.pageIndex = result.pageIndex;
        this.paginator.pageSize = result.pageSize;
        this.setupItems = new MatTableDataSource<SetupItem>(result.data);
      }, error => console.error(error));
  }

}
