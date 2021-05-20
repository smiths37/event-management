import { Component, Inject, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

import { Exhibitor } from '../exhibitors/exhibitor';
import { ExhibitorService } from '../exhibitors/exhibitor.service';

@Component({
  selector: 'app-company-exhibitors',
  templateUrl: './company-exhibitors.component.html',
  styleUrls: ['../../global.css']
})

export class CompanyExhibitorsComponent {
  public companyExhibitors: MatTableDataSource<Exhibitor>;
  public displayColumns: string[] = ['meetingCode', 'meetingStartDate', 'meetingEndDate', 'booths', 'costPerBooth', 'totalCost', 'deposit', 'balance', 'meetingDesc', 'meetingLocation'];

  companyId?: number;

  defaultPageIndex: number = 0;
  defaultPageSize: number = 25;
  public defaultSortColumn: string = "meetingStartDate";
  public defaultSortOrder: string = "asc";

  defaultFilterColumn: string = "meetingCode";
  filterQuery: string = null;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: false }) sort: MatSort;

  constructor(
    private exhibitorService: ExhibitorService,
    private activatedRoute: ActivatedRoute,
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string
  ) { }

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
    this.companyId = +this.activatedRoute.snapshot.paramMap.get("companyId");

    var url = this.baseUrl + 'api/Companies/getcompanyExhibitors/' + this.companyId.toString();
    this.http.get<any>(url)
      .subscribe(result => {
        this.companyExhibitors = new MatTableDataSource<Exhibitor>(result);
        console.log(result);
      }, error => console.error(error));
  }


}
