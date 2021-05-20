import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
//import { HttpClient, HttpParams } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { MailingLists } from './mailing-lists';
import { MailingListService } from './mailing-lists.service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ApiResult } from '../../base.service';
import { BaseFormComponent } from '../../base.form.component'

@Component({
  selector: 'app-mailing-list-edit',
  templateUrl: './mailing-list-edit.component.html',
  styleUrls: ['./mailing-list-edit.component.css', '../../../global.css']
})
export class MailingListEditComponent extends BaseFormComponent implements OnInit {

  title: string;
  form: FormGroup;
  mailingList: MailingLists;
  listCode?: string;
  listId?: number;

  constructor(private activatedRoute: ActivatedRoute,
    private router: Router,
    //private http: HttpClient,
    private listService: MailingListService,
    @Inject('BASE_URL') private baseUrl: string) { super(); }

  ngOnInit() {
    this.form = new FormGroup({
      listName: new FormControl('', Validators.required),
      listCode: new FormControl('', Validators.required),
      allowOnWeb: new FormControl('')
    }, null, this.isDuplicate());
    this.loadData();
  }

  loadData() {
    this.listCode = this.activatedRoute.snapshot.paramMap.get("listCode");

    if (this.listCode) {
      //EDIT MODE - mailingList uses the Code as the Primary Key/Unique identifer
      //var url = this.baseUrl + "api/Lists/" + this.listCode;
      //this.http.get<MailingLists>(url)
      this.listService.get<MailingLists>(this.listCode)
        .subscribe(result => {
          this.mailingList = result;
          this.listId = this.mailingList.listId;
        this.title = "Edit " + this.mailingList.listName;

        this.form.patchValue(this.mailingList);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = 'Create a new Mailing List';
    }
  }

  isDuplicate(): AsyncValidatorFn {
    return (control: AbstractControl): Observable<{ [key: string]: any } | null> => {
      var mailingList = <MailingLists>{};
      mailingList.listId = (this.listId) ? this.listId : 0;
      //mailingList.listCode = (this.listCode) ? this.listCode : null;
      mailingList.listCode = this.form.get("listCode").value;
      mailingList.listName = this.form.get("listName").value;

      //var url = this.baseUrl + "api/Lists/IsDuplicate";
      //return this.http.post<boolean>(url, mailingList)
      return this.listService.isDuplicate(mailingList)
        .pipe(map(result => {
        return (result ? { isDuplicate: true } : null);
      }));
    }
  }

  onSubmit() {
    var mailingList = (this.listCode) ? this.mailingList : <MailingLists>{};

    mailingList.listName = this.form.get("listName").value;
    mailingList.listCode = this.form.get("listCode").value;
    mailingList.listId = this.listId;

    if (this.listCode) {
      //EDIT MODE
      //var url = this.baseUrl + "api/Lists/" + this.mailingList.listCode;
      //this.http.put<MailingLists>(url, mailingList)
      this.listService.put<MailingLists>(mailingList)
        .subscribe(result => {
        console.log("Mailing List " + mailingList.listCode + " has been updated.");
        this.router.navigate(['/mailingLists']);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      //var url = this.baseUrl = "api/Lists";
      //this.http.post<MailingLists>(url, mailingList)
      this.listService.post<MailingLists>(mailingList)
        .subscribe(result => {
        console.log("Mailing List " + result.listCode + " has been created.");
        this.router.navigate(['/mailingLists']);
      }, error => console.error(error));
    }
  }

  onDelete() {
    var mailingList = (this.listCode) ? this.mailingList : <MailingLists>{};
    //var url = this.baseUrl = 'api/mailingLists/' + this.mailingList.listCode;
    //this.http.delete<MailingLists>(url)
    this.listService.delete<MailingLists>(mailingList.listCode)
      .subscribe(result => {
      console.log("Mailing List " + mailingList.listCode + " has been deleted.");
      this.router.navigate(['/mailingLists']);
    }, error => console.error(error));
  }

}
