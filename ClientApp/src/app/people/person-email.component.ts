import { Component, Inject, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

import { PersonEmail } from './person-email';
import { PeopleEmailService } from './person-email.service';

@Component({
  selector: 'app-person-email',
  templateUrl: './person-email.component.html',
  styleUrls: ['../../global.css']
})

export class PersonEmailComponent {
  public personEmails: MatTableDataSource<PersonEmail>;
  public displayColumns: string[] = ['type', 'address'];

  personId?: number;

  defaultPageIndex: number = 0;
  defaultPageSize: number = 25;
  public defaultSortColumn: string = "type";
  public defaultSortOrder: string = "asc";

  defaultFilterColumn: string = "address";
  filterQuery: string = null;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: false }) sort: MatSort;

  constructor(
    private personEmailService: PeopleEmailService,
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
    this.personId = +this.activatedRoute.snapshot.paramMap.get("personId");

    var url = this.baseUrl + 'api/People/getEmails/' + this.personId.toString();
    this.http.get<any>(url)
      .subscribe(result => {
        this.personEmails = new MatTableDataSource<PersonEmail>(result);
        console.log(result);
      }, error => console.error(error));
  }
}
