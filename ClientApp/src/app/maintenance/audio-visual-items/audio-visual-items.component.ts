import { Component, OnInit, Inject, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
//import { HttpClient, HttpParams } from '@angular/common/http';

import { AudioVisualItem } from './audio-visual-items';
import { AudioVisualItemsService } from './audio-visual-items.service';
import { ApiResult } from '../../base.service';

@Component({
  selector: 'app-audio-visual-items',
  templateUrl: './audio-visual-items.component.html',
  styleUrls: ['./audio-visual-items.component.css', '../../../global.css']
})
export class AudioVisualItemsComponent implements OnInit {
  public displayColumns: string[] = ['avId', 'avDesc'];
  public avItems: MatTableDataSource<AudioVisualItem>;

  defaultPageIndex: number = 0;
  defaultPageSize: number = 100;
  public defaultSortColumn: string = "avDesc";
  public defaultSortOrder: string = "asc";

  defaultFilterColumn: string = "avDesc";
  filterQuery: string = null;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: false }) sort: MatSort;

  constructor(
    private avItemsService: AudioVisualItemsService
    //private http: HttpClient,
    //@Inject('BASE_URL') private baseUrl: string
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
    //var url = this.baseUrl + "api/AudioVisualItems";
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

    this.avItemsService.getData<ApiResult<AudioVisualItem>>(event.pageIndex, event.pageSize, sortColumn, sortOrder, filterColumn, filterQuery)
      .subscribe(result => {
        this.paginator.length = result.totalCount;
        this.paginator.pageIndex = result.pageIndex;
        this.paginator.pageSize = result.pageSize;
        this.avItems = new MatTableDataSource<AudioVisualItem>(result.data);
      }, error => console.error(error));
  }
}
