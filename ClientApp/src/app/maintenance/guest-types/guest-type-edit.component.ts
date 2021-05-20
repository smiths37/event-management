import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
//import { HttpClient, HttpParams } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { GuestType } from './guest-type';
import { GuestTypeService } from './guest-type.service';

import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ApiResult } from '../../base.service';
import { BaseFormComponent } from '../../base.form.component'

@Component({
  selector: 'app-guest-type-edit',
  templateUrl: './guest-type-edit.component.html',
  styleUrls: ['./guest-type-edit.component.css', '../../../global.css']
})
export class GuestTypeEditComponent extends BaseFormComponent implements OnInit {

  title: string;
  form: FormGroup;
  guestType: GuestType;
  guestTypeId?: number;

  constructor(private activatedRoute: ActivatedRoute,
    private router: Router,
    //private http: HttpClient,
    private guestTypeService: GuestTypeService,
    @Inject('BASE_URL') private baseUrl: string) { super(); }

  ngOnInit() {
    this.form = new FormGroup({
      guestTypeDesc: new FormControl('', Validators.required)
    }, null, this.isDuplicate());
    this.loadData();
  }

  loadData() {
    this.guestTypeId = +this.activatedRoute.snapshot.paramMap.get("guestTypeId");

    if (this.guestTypeId) {
      //EDIT MODE
      //var url = this.baseUrl + "api/guestTypes/" + this.guestTypeId;
      //this.http.get<GuestType>(url)
      this.guestTypeService.get<GuestType>(this.guestTypeId)
      .subscribe(result => {
        this.guestType = result;
        this.title = "Edit " + this.guestType.guestTypeDesc;

        this.form.patchValue(this.guestType);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = 'Create a new Guest Type';
    }
  }

  isDuplicate(): AsyncValidatorFn {
    return (control: AbstractControl): Observable<{ [key: string]: any } | null> => {
      var guestType = <GuestType>{};
      guestType.guestTypeId = (this.guestTypeId) ? this.guestTypeId : 0;
      guestType.guestTypeDesc = this.form.get("guestTypeDesc").value;

      //var url = this.baseUrl + "api/guestTypes/IsDuplicate";
      //return this.http.post<boolean>(url, guestType)
      return this.guestTypeService.isDuplicate(guestType)
        .pipe(map(result => {
        return (result ? { isDuplicate: true } : null);
      }));
    }
  }

  onSubmit() {
    var guestType = (this.guestTypeId) ? this.guestType : <GuestType>{};

    guestType.guestTypeDesc = this.form.get("guestTypeDesc").value;

    if (this.guestTypeId) {
      //EDIT MODE
      this.guestTypeService.put<GuestType>(this.guestType)
      .subscribe(result => {
        console.log("Guest Type " + guestType.guestTypeId + " has been updated.");
        this.router.navigate(['/guestTypes']);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.guestTypeService.post<GuestType>(guestType)
      .subscribe(result => {
        console.log("Guest Type " + result.guestTypeId + " has been created.");
        this.router.navigate(['/guestTypes']);
      }, error => console.error(error));
    }
  }

  onDelete() {
    var guestType = (this.guestTypeId) ? this.guestType : <GuestType>{};

    this.guestTypeService.delete<GuestType>(guestType.guestTypeId)
    .subscribe(result => {
      console.log("Guest Type " + guestType.guestTypeId + " has been deleted.");
      this.router.navigate(['/guestTypes']);
    }, error => console.error(error));
  }
}
