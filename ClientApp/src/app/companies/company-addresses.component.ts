import { Component, Inject, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

import { CompanyAddress } from './company-address';
import { CompanyAddressService } from './company-address.service';

@Component({
  selector: 'app-company-addresses',
  templateUrl: './company-addresses.component.html',
  styleUrls: ['../../global.css']
})

export class CompanyAddressesComponent {
  public companyAddresses: MatTableDataSource<CompanyAddress>;
  public displayColumns: string[] = ['primary', 'addressType', 'fullAddress', 'phone', 'tollFree', 'fax'];

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

  //  var sortColumn = (this.sort) ? this.sort.active : this.defaultSortColumn;
  //  var sortOrder = (this.sort) ? this.sort.direction : this.defaultSortOrder;
  //  var filterColumn = "companyId";
  //  var filterQuery = this.companyId;

  //  this.companyAddressService.getCompanyAddresses<ApiResult<CompanyAddress>>(event.pageIndex, event.pageSize, sortColumn, sortOrder, filterColumn, filterQuery)
  //    .subscribe(result => {
  //      this.paginator.length = result.totalCount;
  //      this.paginator.pageIndex = result.pageIndex;
  //      this.paginator.pageSize = result.pageSize;
  //      this.companyAddresses = new MatTableDataSource<CompanyAddress>(result.data);
  //    }, error => console.error(error));


    var url = this.baseUrl + 'api/Companies/getAddresses/' + this.companyId.toString();
    this.http.get<any>(url)
      .subscribe(result => {
        //this.paginator.length = result.totalCount;
        this.companyAddresses = new MatTableDataSource<CompanyAddress>(result);
        console.log(result);
      }, error => console.error(error));



  }



}
