import { Component, Inject, ViewChild } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute } from '@angular/router';

import { PersonNote } from './person-note';
import { PersonNoteService } from './person-note.service';

@Component({
  selector: 'app-person-notes',
  templateUrl: './person-notes.component.html',
  styleUrls: ['../../global.css']
})

export class PersonNoteComponent {
  public personNotes: MatTableDataSource<PersonNote>;
  public displayColumns: string[] = ['date', 'personResponsible', 'note'];

  personId?: number;

  defaultPageIndex: number = 0;
  defaultPageSize: number = 25;
  public defaultSortColumn: string = "noteDate";
  public defaultSortOrder: string = "asc";

  defaultFilterColumn: string = "note";
  filterQuery: string = null;

  @ViewChild(MatPaginator, { static: false }) paginator: MatPaginator;
  @ViewChild(MatSort, { static: false }) sort: MatSort;

  constructor(
    private cpersonNoteService: PersonNoteService,
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

    var url = this.baseUrl + 'api/Notes/getPersonNotes/' + this.personId.toString();
    this.http.get<any>(url)
      .subscribe(result => {
        this.personNotes = new MatTableDataSource<PersonNote>(result);
        console.log(result);
      }, error => console.error(error));
  }

}
