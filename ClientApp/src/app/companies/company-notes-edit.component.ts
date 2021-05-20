import { Component, Inject, ViewChild, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';
import { DatePipe } from '@angular/common';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';

import { CompanyNote } from './company-note';
import { CompanyNoteService } from './company-note.service';

import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ApiResult } from '../base.service';
import { BaseFormComponent } from '../base.form.component'
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';

@Component({
  selector: 'app-company-note-edit',
  templateUrl: './company-notes-edit.component.html',
  styleUrls: ['../../global.css'],
  providers: [DatePipe]
})

export class CompanyNoteEditComponent extends BaseFormComponent implements OnInit {
  title: string;
  form: FormGroup;
  note: CompanyNote;
  noteId?: number;
  companyId?: number;
  model: NgbDateStruct;

  constructor(
    private activatedRoute: ActivatedRoute,
    private router: Router,
    private companyNoteService: CompanyNoteService,
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

    this.companyId = +this.activatedRoute.snapshot.paramMap.get('companyId');
    this.noteId = +this.activatedRoute.snapshot.paramMap.get('noteId');

    if (this.noteId) {
      //EDIT MODE
      var url = this.baseUrl + "api/Notes/" + this.noteId;
      this.companyNoteService.get<CompanyNote>(this.noteId)
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
    this.companyId = +this.activatedRoute.snapshot.paramMap.get('companyId');

    var note = (this.noteId) ? this.note : <CompanyNote>{};
    note.companyId = this.companyId;
    note.personResponsible = this.form.get("personResponsible").value;
    note.notes = this.form.get("notes").value;
    note.completedBy = this.form.get("completedBy").value;

    //check for null date values - need to do this so that the null value doesn't try to get converted to a datetime
    if (this.form.get("noteDate").value != null || this.form.get("noteDate").value != '') {
      note.noteDate = this.form.get("noteDate").value;
    }
    
    if (this.form.get("followUpDate").value != null || this.form.get("followUpDate").value != '') {
      note.followUpDate = this.form.get("followUpDate").value;
    }

    if (this.form.get("dateCompleted").value != null || this.form.get("dateCompleted").value != '') {
      note.dateCompleted = this.form.get("dateCompleted").value;
    }

    console.log(note);

    if (this.noteId) {
      //EDIT MODE
      this.companyNoteService.put<CompanyNote>(note)
        .subscribe(result => {
          console.log("Company Note " + note.noteId + " has been updated.");
          this.router.navigate(['/company', this.companyId]);
        }, error => console.log(error));
    } else {
      //ADD NEW MODE
      this.companyNoteService.post<CompanyNote>(note)
        .subscribe(result => {
          console.log("Company Note " + note.noteId + " has been created.");
          this.router.navigate(['/company', this.companyId]);
        }, error => console.log(error));
    }
  }

  onDelete() {
    var note = (this.noteId) ? this.note : <CompanyNote>{};

    this.companyNoteService.delete<CompanyNote>(note.noteId)
      .subscribe(result => {
        console.log("Company Note" + note.noteId + " has been deleted.");
        this.router.navigate(['/company', this.companyId]);
      }, error => console.error(error));
  }

}
