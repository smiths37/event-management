import { Component, OnInit, Inject, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';

import { VendorType } from './vendor-type';
import { VendorTypeService } from './vendor-type-service';
import { ApiResult } from '../../base.service'

@Component({
  selector: 'app-vendor-types',
  templateUrl: './vendor-types.component.html',
  styleUrls: ['./vendor-types.component.css', '../../../global.css']
})
export class VendorTypesComponent implements OnInit {

  public displayColumns: string[] = ['vendorTypeId', 'description'];
  public vendorTypes: MatTableDataSource<VendorType>;

  defaultPageIndex: number = 0;
  defaultPageSize: number = 100;
  public defaultSortColumn: string = "description";
  public defaultSortOrder: string = "asc";

  defaultFilterColumn: string = "description";
  filterQuery: string = null;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: false }) sort: MatSort;

  constructor(private vendorTypeService: VendorTypeService) { }

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

    this.vendorTypeService.getData<ApiResult<VendorType>>(event.pageIndex, event.pageSize, sortColumn, sortOrder, filterColumn, filterQuery)
      .subscribe(result => {
        this.paginator.length = result.totalCount;
        this.paginator.pageIndex = result.pageIndex;
        this.paginator.pageSize = result.pageSize;
        this.vendorTypes = new MatTableDataSource<VendorType>(result.data);
      }, error => console.error(error));
  }

}
