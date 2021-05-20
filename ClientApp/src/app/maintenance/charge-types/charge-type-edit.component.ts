import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
//import { HttpClient, HttpParams } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { ChargeType } from './charge-type';
import { ChargeTypesService } from './charge-types.service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ApiResult } from '../../base.service';
import { BaseFormComponent } from '../../base.form.component'

@Component({
  selector: 'app-charge-type-edit',
  templateUrl: './charge-type-edit.component.html',
  styleUrls: ['./charge-type-edit.component.css', '../../../global.css']
})
export class ChargeTypeEditComponent extends BaseFormComponent implements OnInit {
  title: string;
  form: FormGroup;
  chargeType: ChargeType;
  chargeTypeId?: number;

  constructor(
    private activatedRoute: ActivatedRoute,
    private router: Router,
    //private http: HttpClient,
    private chargeTypesService: ChargeTypesService,
    @Inject('BASE_URL') private baseUrl: string
  ) { super(); }

  ngOnInit() {
    this.form = new FormGroup({
      chargeTypeDesc: new FormControl('', Validators.required)
    }, null, this.isDuplicate());
    this.loadData();
  }

  loadData() {
    this.chargeTypeId = +this.activatedRoute.snapshot.paramMap.get("chargeTypeId");

    if (this.chargeTypeId) {
      //EDIT MODE
      //var url = this.baseUrl + "api/ChargeTypes/" + this.chargeTypeId;
      //this.http.get<ChargeType>(url)
      this.chargeTypesService.get<ChargeType>(this.chargeTypeId)
        .subscribe(result => {
        this.chargeType = result;
        this.title = "Edit " + this.chargeType.chargeTypeDesc;

        this.form.patchValue(this.chargeType);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = 'Create a new Charge Type';
    }
  }

  isDuplicate(): AsyncValidatorFn {
    return (control: AbstractControl): Observable<{ [key: string]: any } | null> => {
      var chargeType = <ChargeType>{};
      chargeType.chargeTypeId = (this.chargeTypeId) ? this.chargeTypeId : 0;
      chargeType.chargeTypeDesc = this.form.get("chargeTypeDesc").value;

      //var url = this.baseUrl + "api/chargeTypes/IsDuplicate";
      //return this.http.post<boolean>(url, chargeType)
      return this.chargeTypesService.isDuplicate(chargeType)
        .pipe(map(result => {
        return (result ? { isDuplicate: true } : null);
      }));
    }
  }

  onSubmit() {
    var chargeType = (this.chargeTypeId) ? this.chargeType : <ChargeType>{};

    chargeType.chargeTypeDesc = this.form.get("chargeTypeDesc").value;

    if (this.chargeTypeId) {
      //EDIT MODE
      //var url = this.baseUrl + "api/ChargeTypes/" + this.chargeType.chargeTypeId;
      //this.http.put<ChargeType>(url, chargeType)
      this.chargeTypesService.put<ChargeType>(this.chargeType)
        .subscribe(result => {
        console.log("Charge Type " + chargeType.chargeTypeId + " has been updated.");
        this.router.navigate(['/chargeTypes']);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      //var url = this.baseUrl = "api/ChargeTypes";
      //this.http.post<ChargeType>(url, chargeType)
      this.chargeTypesService.post<ChargeType>(chargeType)
        .subscribe(result => {
        console.log("Charge Type " + result.chargeTypeId + " has been created.");
        this.router.navigate(['/chargeTypes']);
      }, error => console.error(error));
    }
  }

  onDelete() {
    var chargeType = (this.chargeTypeId) ? this.chargeType : <ChargeType>{};
    //var url = this.baseUrl = 'api/chargeTypes/' + this.chargeType.chargeTypeId;
    //this.http.delete<ChargeType>(url)
    this.chargeTypesService.delete<ChargeType>(chargeType.chargeTypeId)
      .subscribe(result => {
      console.log("Charge Type " + chargeType.chargeTypeId + " has been deleted.");
      this.router.navigate(['/chargeTypes']);
    }, error => console.error(error));
  }

}
