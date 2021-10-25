import { Component, Inject, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

import { PersonCeCredit } from './person-ce-credit';
import { PeopleCeCreditsService } from './person-ce-credits.service';

@Component({
  selector: 'app-person-ce-credits',
  templateUrl: './person-ce-credits.component.html',
  styleUrls: ['../../global.css']
})

export class PersonCeCreditComponent {
  public personCeCredits: MatTableDataSource<PersonCeCredit>;
  public displayColumns: string[] = ['creditDate', 'title', 'meetingCode', 'regCode', 'sessionCode', 'creditTypeCode', 'creditUnits', 'selfReported'];

  personId?: number;

  defaultPageIndex: number = 0;
  defaultPageSize: number = 25;
  //public defaultSortColumn: string = "creditDate";
  public defaultSortColumn: string = "title";
  public defaultSortOrder: string = "asc";

  defaultFilterColumn: string = "title";
  filterQuery: string = null;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, null) sort: MatSort;

  constructor(
  private personCeCreditService: PeopleCeCreditsService,
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
    //this.id = +this.activatedRoute.snapshot.paramMap.get("id");
    this.personId = +this.activatedRoute.snapshot.paramMap.get("personId");

    var url = this.baseUrl + 'api/People/getCeCredits/' + this.personId.toString();
    this.http.get<any>(url)
      .subscribe(result => {
        this.personCeCredits = new MatTableDataSource<PersonCeCredit>(result);
        console.log(result);
      }, error => console.error(error));
  }
}
