import { Component, Inject, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

import { CompanyAddress } from '../companies/company-address';
import { CompanyAddressService } from '../companies/company-address.service';

@Component({
  selector: 'app-person-company-address',
  templateUrl: './person-company-address.html',
  styleUrls: ['../../global.css']
})

export class PersonCompanyAddressComponent {
  public companyAddresses: MatTableDataSource<CompanyAddress>;
  public displayColumns: string[] = ['selection', 'primary', 'addressType', 'fullAddress'];

  companyId?: number;

  defaultPageIndex: number = 0;
  defaultPageSize: number = 25;
  public defaultSortColumn: string = "primary";
  public defaultSortOrder: string = "asc";

  defaultFilterColumn: string = "address1";
  filterQuery: string = null;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: false }) sort: MatSort;

  constructor(
    private companyAddressService: CompanyAddressService,
    private activatedRoute: ActivatedRoute,
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string
  ) { }

  ngOnInit() {
    this.loadData();
    this.companyAddresses.sort = this.sort;
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

    var url = this.baseUrl + 'api/Companies/getAddresses/' + this.companyId.toString();
    this.http.get<any>(url)
      .subscribe(result => {
        //this.paginator.length = result.totalCount;
        this.companyAddresses = new MatTableDataSource<CompanyAddress>(result);
        console.log(result);
      }, error => console.error(error));
  }
}
