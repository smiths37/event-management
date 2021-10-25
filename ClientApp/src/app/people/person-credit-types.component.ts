import { Component, Inject, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

import { PersonCreditType } from './person-credit-type';
import { PeopleCreditTypeService } from './person-credit-types.service';

@Component({
  selector: 'app-person-credit-types',
  templateUrl: './person-credit-types.component.html',
  styleUrls: ['../../global.css']
})

export class PersonCreditTypeComponent {
  public personCreditTypes: MatTableDataSource<PersonCreditType>;
  public displayColumns: string[] = ['creditType', 'description'];

  //id?: number;
  personId?: number;

  defaultPageIndex: number = 0;
  defaultPageSize: number = 25;
  public defaultSortColumn: string = "creditType";
  public defaultSortOrder: string = "asc";

  defaultFilterColumn: string = "description";
  filterQuery: string = null;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: false }) sort: MatSort;

  constructor(
    private personCreditTypeService: PeopleCreditTypeService,
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

    var url = this.baseUrl + 'api/People/getCreditTypes/' + this.personId.toString();
    this.http.get<any>(url)
      .subscribe(result => {
        this.personCreditTypes = new MatTableDataSource<PersonCreditType>(result);
        console.log(result);
      }, error => console.error(error));
  }
}
