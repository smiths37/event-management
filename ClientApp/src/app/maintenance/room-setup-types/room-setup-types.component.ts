import { Component, OnInit, Inject, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
//import { HttpClient, HttpParams } from '@angular/common/http';

import { RoomSetup } from './room-setup-type';
import { RoomSetupTypeService } from './room-setup-type-service';
import { ApiResult } from '../../base.service'
@Component({
  selector: 'app-room-setup-types',
  templateUrl: './room-setup-types.component.html',
  styleUrls: ['./room-setup-types.component.css', '../../../global.css']
})
export class RoomSetupTypesComponent implements OnInit {
  public displayColumns: string[] = ['setupId', 'setupDesc'];
  public setups: MatTableDataSource<RoomSetup>;

  defaultPageIndex: number = 0;
  defaultPageSize: number = 100;
  public defaultSortColumn: string = "setupDesc";
  public defaultSortOrder: string = "asc";

  defaultFilterColumn: string = "setupDesc";
  filterQuery: string = null;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: false }) sort: MatSort;

  constructor(private roomSetupTypeService: RoomSetupTypeService) { }

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

    this.roomSetupTypeService.getData<ApiResult<RoomSetup>>(event.pageIndex, event.pageSize, sortColumn, sortOrder, filterColumn, filterQuery)
      .subscribe(result => {
        this.paginator.length = result.totalCount;
        this.paginator.pageIndex = result.pageIndex;
        this.paginator.pageSize = result.pageSize;
        this.setups = new MatTableDataSource<RoomSetup>(result.data);
      }, error => console.error(error));
  }

}
