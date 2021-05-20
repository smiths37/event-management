import { Component, Inject, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

import { ExhibitorNote } from './exhibitor-note';
import { ExhibitorNoteService } from './exhibitor-note.service';

@Component({
  selector: 'app-exhibitor-notes',
  templateUrl: './exhibitor-notes.component.html',
  styleUrls: ['../../global.css']
})

export class ExhibitorNoteComponent {
  public exhibitorNotes: MatTableDataSource<ExhibitorNote>;
  public displayColumns: string[] = ['date', 'personResponsible', 'note'];

  exhibitorId?: number;
  companyId?: number;
  meetingCode: string;

  defaultPageIndex: number = 0;
  defaultPageSize: number = 25;
  public defaultSortColumn: string = "noteDate";
  public defaultSortOrder: string = "asc";

  defaultFilterColumn: string = "note";
  filterQuery: string = null;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: false }) sort: MatSort;

  constructor(
    private exhibitorNoteService: ExhibitorNoteService,
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
    this.exhibitorId = +this.activatedRoute.snapshot.paramMap.get("exhibitorId");
    this.companyId = +this.activatedRoute.snapshot.paramMap.get("companyId");
    this.meetingCode = this.activatedRoute.snapshot.paramMap.get("meetingCode");

    var url = this.baseUrl + 'api/Notes/getExhibitorNotes/' + this.exhibitorId.toString();
    this.http.get<any>(url)
      .subscribe(result => {
        this.exhibitorNotes = new MatTableDataSource<ExhibitorNote>(result);
        console.log(result);
      }, error => console.error(error));
  }

}
