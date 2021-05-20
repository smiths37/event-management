import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { HttpClient, HttpParams } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { AddressType } from './address-type';
import { AddressTypeService } from './address-type.service';
import { ApiResult } from '../../base.service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { BaseFormComponent } from '../../base.form.component'

@Component({
  selector: 'app-address-type-edit',
  templateUrl: './address-type-edit.component.html',
  styleUrls: ['./address-type-edit.component.css', '../../../global.css']
})
export class AddressTypeEditComponent extends BaseFormComponent implements OnInit {
  title: string;
  form: FormGroup;
  addressType: AddressType;
  addressTypeId?: number;

  constructor(
    private activatedRoute: ActivatedRoute,
    private router: Router,
    //private http: HttpClient,
    private addressTypeService: AddressTypeService,
    @Inject('BASE_URL') private baseUrl: string
  ) { super(); }

  ngOnInit() {
    this.form = new FormGroup({
      addressTypeDesc: new FormControl('', Validators.required)
    }, null, this.isDuplicate());
    this.loadData();
  }

  loadData() {
    this.addressTypeId = +this.activatedRoute.snapshot.paramMap.get("addressTypeId");

    if (this.addressTypeId) {
      //EDIT MODE
      //var url = this.baseUrl + "api/addressTypes/" + this.addressTypeId;
      //this.http.get<AddressType>(url)
      this.addressTypeService.get<AddressType>(this.addressTypeId)
      .subscribe(result => {
        this.addressType = result;
        this.title = "Edit " + this.addressType.addressTypeDesc;

        this.form.patchValue(this.addressType);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = 'Create a new Address Type';
    }
  }

  isDuplicate(): AsyncValidatorFn {
    return (control: AbstractControl): Observable<{ [key: string]: any } | null> => {
      var addressType = <AddressType>{};
      addressType.addressTypeId = (this.addressTypeId) ? this.addressTypeId : 0;
      addressType.addressTypeDesc = this.form.get("addressTypeDesc").value;

      //var url = this.baseUrl + "api/addressTypes/IsDuplicate";
      //return this.http.post<boolean>(url, addressType)
      return this.addressTypeService.isDuplicate(addressType)
        .pipe(map(result => {
        return (result ? { isDuplicate: true } : null);
      }));
    }
  }

  onSubmit() {
    var addressType = (this.addressTypeId) ? this.addressType : <AddressType>{};

    addressType.addressTypeDesc = this.form.get("addressTypeDesc").value;

    if (this.addressTypeId) {
      //EDIT MODE
      //var url = this.baseUrl + "api/addressTypes/" + this.addressType.addressTypeId;
      //this.http.put<AddressType>(url, addressType)
      this.addressTypeService.put<AddressType>(this.addressType)
        .subscribe(result => {
        console.log("Address Type " + addressType.addressTypeId + " has been updated.");
        this.router.navigate(['/addressTypes']);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      //var url = this.baseUrl = "api/addressTypes";
      //this.http.post<AddressType>(url, addressType)
      this.addressTypeService.post<AddressType>(addressType)
        .subscribe(result => {
        console.log("Address Type " + result.addressTypeId + " has been created.");
        this.router.navigate(['/addressTypes']);
      }, error => console.error(error));
    }
  }

  onDelete() {
    var addressType = (this.addressTypeId) ? this.addressType : <AddressType>{};
    //var url = this.baseUrl = 'api/addressTypes/' + this.addressType.addressTypeId;
    //this.http.delete<AddressType>(url)
    this.addressTypeService.delete<AddressType>(addressType.addressTypeId)
      .subscribe(result => {
      console.log("Address Type " + addressType.addressTypeId + " has been deleted.");
      this.router.navigate(['/addressTypes']);
    }, error => console.error(error));
  }

}
