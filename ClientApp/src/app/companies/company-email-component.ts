import { Component, Inject, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

import { CompanyEmail } from './company-email';
import { CompanyEmailService } from './company-email.service';

@Component({
  selector: 'app-company-email',
  templateUrl: './company-email.component.html',
  styleUrls: ['../../global.css']
})

export class CompanyEmailComponent {
  public companyEmails: MatTableDataSource<CompanyEmail>;
  public displayColumns: string[] = ['type', 'address'];

  companyId?: number;

  defaultPageIndex: number = 0;
  defaultPageSize: number = 25;
  public defaultSortColumn: string = "type";
  public defaultSortOrder: string = "asc";

  defaultFilterColumn: string = "address";
  filterQuery: string = null;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: false }) sort: MatSort;

  constructor(
    private companyEmailService: CompanyEmailService,
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

    var url = this.baseUrl + 'api/Companies/getEmails/' + this.companyId.toString();
    this.http.get<any>(url)
      .subscribe(result => {
        this.companyEmails = new MatTableDataSource<CompanyEmail>(result);
        console.log(result);
      }, error => console.error(error));
  }
}
