import { Component, Inject, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

import { Person } from '../people/person';
import { PersonService } from '../people/person.service';

@Component({
  selector: 'app-company-people',
  templateUrl: './company-people.component.html',
  styleUrls: ['../../global.css']
})

export class CompanyPeopleComponent {
  public companyPeople: MatTableDataSource<Person>;
  public displayColumns: string[] = ['prefix', 'firstName', 'lastName', 'suffix', 'peopleType', 'contactType'];

  companyId?: number;

  defaultPageIndex: number = 0;
  defaultPageSize: number = 25;
  public defaultSortColumn: string = "lastName";
  public defaultSortOrder: string = "asc";

  defaultFilterColumn: string = "lastName";
  filterQuery: string = null;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: false }) sort: MatSort;

  constructor(
    private peopleService: PersonService,
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
    console.log("CompanyId = " + this.companyId);

    var url = this.baseUrl + 'api/Companies/getCompanyPeople/' + this.companyId.toString();
    console.log("url: " + url);
    this.http.get<any>(url)
      .subscribe(result => {
        this.companyPeople = new MatTableDataSource<Person>(result);
        console.log(result);
      }, error => console.error(error));
  }
}
