import { Component, OnInit, Inject, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';

import { Source } from './source-type';
import { SourceTypeService } from './source-type-service';
import { ApiResult } from '../../base.service'

@Component({
  selector: 'app-source-types',
  templateUrl: './source-types.component.html',
  styleUrls: ['./source-types.component.css', '../../../global.css']
})
export class SourceTypesComponent implements OnInit {
  public displayColumns: string[] = ['sourceId', 'sourceDesc'];
  public sources: MatTableDataSource<Source>;

  defaultPageIndex: number = 0;
  defaultPageSize: number = 100;
  public defaultSortColumn: string = "sourceDesc";
  public defaultSortOrder: string = "asc";

  defaultFilterColumn: string = "sourceDesc";
  filterQuery: string = null;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: false }) sort: MatSort;

  constructor(private sourceTypeService: SourceTypeService) { }

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

    this.sourceTypeService.getData<ApiResult<Source>>(event.pageIndex, event.pageSize, sortColumn, sortOrder, filterColumn, filterQuery)
      .subscribe(result => {
        this.paginator.length = result.totalCount;
        this.paginator.pageIndex = result.pageIndex;
        this.paginator.pageSize = result.pageSize;
        this.sources = new MatTableDataSource<Source>(result.data);
      }, error => console.error(error));
  }

}
