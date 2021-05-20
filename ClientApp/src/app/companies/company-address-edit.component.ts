import { Component, Inject, ViewChild, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { CompanyAddress } from './company-address';
import { CompanyAddressService } from './company-address.service';
import { AddressType } from '../maintenance/address-types/address-type';
import { State } from '../maintenance/states/state';
import { Country } from '../maintenance/countries/country';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ApiResult } from '../base.service';
import { BaseFormComponent } from '../base.form.component'
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { AddressTypeService } from '../maintenance/address-types/address-type.service';
import { StateService } from '../maintenance/states/states.service';
import { CountryService } from '../maintenance/countries/country.service';

@Component({
  selector: 'app-company-address-edit',
  templateUrl: './company-address-edit.component.html',
  styleUrls: ['../../global.css']
})

export class CompanyAddressEditComponent extends BaseFormComponent implements OnInit {
  title: string;
  form: FormGroup;
  address: CompanyAddress;
  addressId?: number;
  companyId?: number;
  addressTypes: AddressType[];
  states: State[];
  countries: Country[];

  constructor(
    private activatedRoute: ActivatedRoute,
    private router: Router,
    private companyAddressService: CompanyAddressService,
    private addressTypeService: AddressTypeService,
    private stateService: StateService,
    private countryService: CountryService,
    @Inject('BASE_URL') private baseUrl: string
  ) {
    super();
  }

  ngOnInit() {
    this.form = new FormGroup({
      primary: new FormControl(''),
      addressType: new FormControl('', Validators.required),
      address1: new FormControl('', Validators.required),
      address2: new FormControl(''),
      city: new FormControl('', Validators.required),
      country: new FormControl(''),
      state: new FormControl(''),
      zip: new FormControl(''),
      phone: new FormControl(''),
      fax: new FormControl(''),
      tollFree: new FormControl('')
    });
    this.loadData();
  }

  loadData() {
    //load address types, states, countries
    this.loadAddressTypes();
    this.loadStates();
    this.loadCountries();

    this.companyId = +this.activatedRoute.snapshot.paramMap.get('companyId');
    this.addressId = +this.activatedRoute.snapshot.paramMap.get('addressId');
    console.log(this.activatedRoute.snapshot.paramMap.get('companyId'));
    console.log(this.activatedRoute.snapshot.paramMap.get('addressId'));

    if (this.addressId) {
      //EDIT MODE
      var url = this.baseUrl + "api/companyAddresses/" + this.addressId;
      this.companyAddressService.get<CompanyAddress>(this.addressId)
        .subscribe(result => {
          this.address = result;
          console.log(result);
          this.title = "Edit Address";

          this.form.patchValue(this.address);

        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = "Add a new Address";
    }
  }

  loadAddressTypes() {
    this.addressTypeService.getData<ApiResult<AddressType>>(0, 9999, "addressTypeDesc", "asc", null, null)
      .subscribe(result => {
        this.addressTypes = result.data;
      },
        error => console.log(error));
  }

  loadStates() {
    this.stateService.getData<ApiResult<State>>(0, 9999, "stateName", "asc", null, null)
      .subscribe(result => {
        this.states = result.data;
      },
        error => console.log(error));
  }

  loadCountries() {
    this.countryService.getData<ApiResult<Country>>(0, 9999, "countryName", "asc", null, null)
      .subscribe(result => {
        this.countries = result.data;
      },
        error => console.log(error));
  }

  onSubmit() {
    var address = (this.addressId) ? this.address : <CompanyAddress>{};
    address.companyId = this.companyId;     
    address.addressType = this.form.get("addressType").value;
    address.address1 = this.form.get("address1").value;
    address.city = this.form.get("city").value;

    //check field values, only pass these if they contain something
    this.form.get("state").value != "" ? address.state = this.form.get("state").value : null;
    this.form.get("country").value != "" ? address.countryId = this.form.get("country").value : null;
    this.form.get("tollFree").value != "" ? address._800 = this.form.get("tollFree").value : null;
    this.form.get("fax").value != "" ? address.fax = this.form.get("fax").value : null;
    this.form.get("phone").value != "" ? address.phone = this.form.get("phone").value : null;
    this.form.get("address2").value != "" ? address.address2 = this.form.get("address2").value : null;
    this.form.get("zip").value != "" ? address.zip = this.form.get("zip").value : null;

    this.form.controls["primary"].value == "" ? address.primary = false : address.primary = true

    console.log(address);

    if (this.addressId) {
      //EDIT MODE
      this.companyAddressService.put<CompanyAddress>(address)
        .subscribe(result => {
          console.log("Company Address " + address.addressId + " has been updated.");
          this.router.navigate(['/company', this.companyId]);
        }, error => console.log(error));
    } else {
      //ADD NEW MODE
      this.companyAddressService.post<CompanyAddress>(address)
        .subscribe(result => {
          console.log("Company Address " + address.addressId + " has been created.");
          this.router.navigate(['/company', this.companyId]);
        }, error => console.log(error));
    }
  }

  onDelete() {
    var address = (this.addressId) ? this.address : <CompanyAddress>{};

    this.companyAddressService.delete<CompanyAddress>(address.addressId)
      .subscribe(result => {
        console.log("Company Address" + address.addressId + " has been deleted.");
        this.router.navigate(['/company', this.companyId]);
      }, error => console.error(error));
  }
}
