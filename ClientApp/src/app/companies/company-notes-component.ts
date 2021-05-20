import { Component, Inject, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

import { CompanyNote } from './company-note';
import { CompanyNoteService } from './company-note.service';

@Component({
  selector: 'app-company-notes',
  templateUrl: './company-notes.component.html',
  styleUrls: ['../../global.css']
})

export class CompanyNoteComponent {
  public companyNotes: MatTableDataSource<CompanyNote>;
  public displayColumns: string[] = ['date', 'personResponsible', 'note'];

  companyId?: number;

  defaultPageIndex: number = 0;
  defaultPageSize: number = 25;
  public defaultSortColumn: string = "noteDate";
  public defaultSortOrder: string = "asc";

  defaultFilterColumn: string = "note";
  filterQuery: string = null;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: false }) sort: MatSort;

  constructor(
    private companyNoteService: CompanyNoteService,
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

    var url = this.baseUrl + 'api/Notes/getCompanyNotes/' + this.companyId.toString();
    this.http.get<any>(url)
      .subscribe(result => {
        this.companyNotes = new MatTableDataSource<CompanyNote>(result);
        console.log(result);
      }, error => console.error(error));
  }

}
