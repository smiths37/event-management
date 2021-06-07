import { Component, Inject, ViewChild, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';
import { DatePipe } from '@angular/common';
import { NgbDateStruct, NgbDate } from '@ng-bootstrap/ng-bootstrap';

import { ExhibitorNote } from './exhibitor-note';
import { ExhibitorNoteService } from './exhibitor-note.service';

import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ApiResult } from '../base.service';
import { BaseFormComponent } from '../base.form.component'
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';

@Component({
  selector: 'app-exhibitor-note-edit',
  templateUrl: './exhibitor-notes-edit.component.html',
  styleUrls: ['../../global.css'],
  providers: [DatePipe]
})

export class ExhibitorNoteEditComponent extends BaseFormComponent implements OnInit {
  model: NgbDateStruct;
  title: string;
  form: FormGroup;
  note: ExhibitorNote;
  noteId?: number;
  exhibitorId?: number;
  companyId?: number;
  meetingCode: string;
  noteDateModel: NgbDate;
  followUpDateModel: NgbDate;
  completedDateModel: NgbDate;

  constructor(
    private activatedRoute: ActivatedRoute,
    private router: Router,
    private exhibitorNoteService: ExhibitorNoteService,
    private datePipe: DatePipe,
    @Inject('BASE_URL') private baseUrl: string
  ) {
    super();
  }

  ngOnInit() {
    this.form = new FormGroup({
      noteDate: new FormControl(''),
      followUpDate: new FormControl(''),
      personResponsible: new FormControl(''),
      notes: new FormControl(''),
      dateCompleted: new FormControl(''),
      completedBy: new FormControl('')
    });
    this.loadData();
  }

  loadData() {

    this.exhibitorId = +this.activatedRoute.snapshot.paramMap.get('exhibitorId');
    this.noteId = +this.activatedRoute.snapshot.paramMap.get('noteId');
    this.companyId = +this.activatedRoute.snapshot.paramMap.get('companyId');
    this.meetingCode = this.activatedRoute.snapshot.paramMap.get('meetingCode');

    if (this.noteId) {
      //EDIT MODE
      var url = this.baseUrl + "api/Notes/" + this.noteId;
      this.exhibitorNoteService.get<ExhibitorNote>(this.noteId)
        .subscribe(result => {
          this.note = result;
          console.log(result);
          this.title = "Edit Note";

          this.form.patchValue(this.note);

          //Date picker needs JSON values for year, month, and day
          const noteYear = Number(this.datePipe.transform(this.note.noteDate, 'yyyy'));
          const noteMonth = Number(this.datePipe.transform(this.note.noteDate, 'MM'));
          const noteDay = Number(this.datePipe.transform(this.note.noteDate, 'dd'));
          this.form.get('noteDate').setValue({
            year: noteYear,
            month: noteMonth,
            day: noteDay
          });

          const followUpYear = Number(this.datePipe.transform(this.note.followUpDate, 'yyyy'));
          const followUpMonth = Number(this.datePipe.transform(this.note.followUpDate, 'MM'));
          const followupDay = Number(this.datePipe.transform(this.note.followUpDate, 'dd'));
          this.form.get('followUpDate').setValue({
            year: followUpYear,
            month: followUpMonth,
            day: followupDay
          });

          const completedYear = Number(this.datePipe.transform(this.note.dateCompleted, 'yyyy'));
          const completedMonth = Number(this.datePipe.transform(this.note.dateCompleted, 'MM'));
          const completedDay = Number(this.datePipe.transform(this.note.dateCompleted, 'dd'));
          this.form.get('dateCompleted').setValue({
            year: completedYear,
            month: completedMonth,
            day: completedDay
          });

        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = "Add a new Note";
    }
  }

  onSubmit() {
    this.exhibitorId = +this.activatedRoute.snapshot.paramMap.get('exhibitorId');

    var note = (this.noteId) ? this.note : <ExhibitorNote>{};
    note.exhibitorId = this.exhibitorId;
    note.personResponsible = this.form.get("personResponsible").value;
    note.notes = this.form.get("notes").value;
    note.completedBy = this.form.get("completedBy").value;

    //check for null date values and if value exists - need to do this so that the null value doesn't try to get converted to a datetime
    if (this.form.get("noteDate").value && (this.form.get("noteDate").value != null || this.form.get("noteDate").value != '')) {
      //Date picker passes back JSON date, format this as a date to send to DB
      var year: string;
      var day: string;
      var month: string;
      var fullDate: Date;
      year = this.form.get("noteDate").value.year;
      day = this.form.get("noteDate").value.day;
      month = this.form.get("noteDate").value.month;
      fullDate = new Date(year + "-" + month + "-" + day);
      note.noteDate = fullDate;
    }

    if (this.form.get("followUpDate").value && (this.form.get("followUpDate").value != null || this.form.get("followUpDate").value != '')) {
      //Date picker passes back JSON date, format this as a date to send to DB
      var year: string;
      var day: string;
      var month: string;
      var fullDate: Date;
      year = this.form.get("followUpDate").value.year;
      day = this.form.get("followUpDate").value.day;
      month = this.form.get("followUpDate").value.month;
      fullDate = new Date(year + "-" + month + "-" + day);
      note.followUpDate = fullDate;
    }
    if (this.form.get("dateCompleted").value && (this.form.get("dateCompleted").value != null || this.form.get("dateCompleted").value != '')) {
      //Date picker passes back JSON date, format this as a date to send to DB
      var year: string;
      var day: string;
      var month: string;
      var fullDate: Date;
      year = this.form.get("dateCompleted").value.year;
      day = this.form.get("dateCompleted").value.day;
      month = this.form.get("dateCompleted").value.month;
      fullDate = new Date(year + "-" + month + "-" + day);
      note.dateCompleted = fullDate;
    }

    if (this.noteId) {
      //EDIT MODE
      this.exhibitorNoteService.put<ExhibitorNote>(note)
        .subscribe(result => {
          console.log("Exhibitor Note " + note.noteId + " has been updated.");
          this.router.navigate(['/exhibitor', this.companyId, this.meetingCode, this.exhibitorId]);
        }, error => console.log(error));
    } else {
      //ADD NEW MODE
      this.exhibitorNoteService.post<ExhibitorNote>(note)
        .subscribe(result => {
          console.log("Exhibitor Note " + note.noteId + " has been created.");
          this.router.navigate(['/exhibitor', this.companyId, this.meetingCode, this.exhibitorId]);
        }, error => console.log(error));
    }
  }

  onDelete() {
    var note = (this.noteId) ? this.note : <ExhibitorNote>{};

    this.exhibitorNoteService.delete<ExhibitorNote>(note.noteId)
      .subscribe(result => {
        console.log("Exhibitor Note" + note.noteId + " has been deleted.");
        this.router.navigate(['/exhibitor', this.companyId, this.meetingCode, this.exhibitorId]);
      }, error => console.error(error));
  }

}
