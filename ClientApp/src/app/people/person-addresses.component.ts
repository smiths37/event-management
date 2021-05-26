import { Component, Inject, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

import { PersonAddress } from './person-address';
import { PersonAddressService } from './person-address.service';

@Component({
  selector: 'app-person-addresses',
  templateUrl: './person-addresses.component.html',
  styleUrls: ['../../global.css']
})

export class PersonAddressesComponent {
  public personAddresses: MatTableDataSource<PersonAddress>;
  public displayColumns: string[] = ['primary', 'addressType', 'fullAddress', 'phone', 'extension', 'fax'];

  personId?: number;

  defaultPageIndex: number = 0;
  defaultPageSize: number = 25;
  public defaultSortColumn: string = "primary";
  public defaultSortOrder: string = "asc";

  defaultFilterColumn: string = "address1";
  filterQuery: string = null;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: false }) sort: MatSort;

  constructor(
    private personAddressService: PersonAddressService,
    private activatedRoute: ActivatedRoute,
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string
  ) { }

  ngOnInit() {
    this.loadData();
    this.personAddresses.sort = this.sort;
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
    
    var url = this.baseUrl + 'api/People/getAddresses/' + this.personId.toString();
    this.http.get<any>(url)
      .subscribe(result => {
        //this.paginator.length = result.totalCount;
        this.personAddresses = new MatTableDataSource<PersonAddress>(result);
        console.log(result);
      }, error => console.error(error));
  }
}
