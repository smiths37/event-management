import { Component, OnInit, Inject, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';

import { SpeakerType } from './speaker-type';
import { SpeakerTypeService } from './speaker-type-service';
import { ApiResult } from '../../base.service'

@Component({
  selector: 'app-speaker-types',
  templateUrl: './speaker-types.component.html',
  styleUrls: ['./speaker-types.component.css', '../../../global.css']
})
export class SpeakerTypesComponent implements OnInit {

  public displayColumns: string[] = ['speakerTypeId', 'speakerTypeDesc'];
  public speakerTypes: MatTableDataSource<SpeakerType>;

  defaultPageIndex: number = 0;
  defaultPageSize: number = 100;
  public defaultSortColumn: string = "speakerTypeDesc";
  public defaultSortOrder: string = "asc";

  defaultFilterColumn: string = "speakerTypeDesc";
  filterQuery: string = null;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: false }) sort: MatSort;

  constructor(private speakerTypeService: SpeakerTypeService) { }

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

    this.speakerTypeService.getData<ApiResult<SpeakerType>>(event.pageIndex, event.pageSize, sortColumn, sortOrder, filterColumn, filterQuery)
      .subscribe(result => {
        this.paginator.length = result.totalCount;
        this.paginator.pageIndex = result.pageIndex;
        this.paginator.pageSize = result.pageSize;
        this.speakerTypes = new MatTableDataSource<SpeakerType>(result.data);
      }, error => console.error(error));
  }

}
