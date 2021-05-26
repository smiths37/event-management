import { Component, Inject, ViewChild, OnInit } from '@angular/core';
import { MatTableDataSource } from '@angular/material/table';
import { MatPaginator, PageEvent } from '@angular/material/paginator';
import { MatSort } from '@angular/material/sort';
import { HttpClient } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { PersonAddress } from './person-address';
import { PersonAddressService } from './person-address.service';
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
import { Person } from './person';

@Component({
  selector: 'app-person-address-edit',
  templateUrl: './person-address-edit.component.html',
  styleUrls: ['../../global.css']
})

export class PersonAddressEditComponent extends BaseFormComponent implements OnInit {
  title: string;
  form: FormGroup;
  address: PersonAddress;
  addressId?: number;
  personId?: number;
  companyId?: number;
  addressTypes: AddressType[];
  states: State[];
  countries: Country[];

  constructor(
    private activatedRoute: ActivatedRoute,
    private router: Router,
    private personAddressService: PersonAddressService,
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
      extension: new FormControl('')
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
    this.personId = +this.activatedRoute.snapshot.paramMap.get('personId');
    console.log('Person Id=' + this.activatedRoute.snapshot.paramMap.get('personId'));
    console.log('Address Id=' + this.activatedRoute.snapshot.paramMap.get('addressId'));
    console.log('Company Id=' + this.activatedRoute.snapshot.paramMap.get('companyId'));

    if (this.addressId) {
      //EDIT MODE
      var url = this.baseUrl + "api/peopleAddresses/" + this.addressId;
      this.personAddressService.get<PersonAddress>(this.addressId)
        .subscribe(result => {
          this.address = result;
          console.log(result);
          this.title = "Edit Address";

          this.form.patchValue(this.address);

        }, error => console.error(error));
    } else if (this.personId && this.companyId) {
       //Copy Company Address


    } else

    {
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
    var address = (this.addressId) ? this.address : <PersonAddress>{};
    address.companyId = this.companyId;
    address.personId = this.personId;

    console.log('Person Id=' + this.personId);
    console.log('Address Id=' + this.addressId);
    console.log('Company Id=' + this.companyId);


    address.addressType = this.form.get("addressType").value;
    address.address1 = this.form.get("address1").value;
    address.city = this.form.get("city").value;

    //check field values, only pass these if they contain something
    this.form.get("state").value != "" ? address.state = this.form.get("state").value : null;
    this.form.get("country").value != "" ? address.countryId = this.form.get("country").value : null;
    this.form.get("extension").value != "" ? address.extension = this.form.get("extension").value : null;
    this.form.get("fax").value != "" ? address.fax = this.form.get("fax").value : null;
    this.form.get("phone").value != "" ? address.phone = this.form.get("phone").value : null;
    this.form.get("address2").value != "" ? address.address2 = this.form.get("address2").value : null;
    this.form.get("zip").value != "" ? address.zip = this.form.get("zip").value : null;
    this.form.controls["primary"].value == "" ? address.primary = false : address.primary = true

    console.log(address);

    if (this.addressId) {
      //EDIT MODE
      this.personAddressService.put<PersonAddress>(address)
        .subscribe(result => {
          console.log("Person Address " + address.addressId + " has been updated.");
          this.router.navigate(['/person', this.personId]);
        }, error => console.log(error));
    } else {
      //ADD NEW MODE
      this.personAddressService.post<PersonAddress>(address)
        .subscribe(result => {
          console.log("Person Address " + address.addressId + " has been created.");
          this.router.navigate(['/person', this.personId]);
        }, error => console.log(error));
    }
  }

  onDelete() {
    var address = (this.addressId) ? this.address : <PersonAddress>{};

    this.personAddressService.delete<PersonAddress>(address.addressId)
      .subscribe(result => {
        console.log("Person Address" + address.addressId + " has been deleted.");
        this.router.navigate(['/person', this.personId]);
      }, error => console.error(error));
  }
}
