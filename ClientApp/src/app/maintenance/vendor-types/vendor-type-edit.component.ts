import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

import { VendorType } from './vendor-Type';
import { VendorTypeService } from './vendor-type-service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ApiResult } from '../../base.service';
import { BaseFormComponent } from '../../base.form.component'

@Component({
  selector: 'app-vendor-type-edit',
  templateUrl: './vendor-type-edit.component.html',
  styleUrls: ['./vendor-type-edit.component.css', '../../../global.css']
})
export class VendorTypeEditComponent extends BaseFormComponent implements OnInit {

  title: string;
  form: FormGroup;
  vendorType: VendorType;
  vendorTypeId?: number;

  constructor(private activatedRoute: ActivatedRoute,
    private router: Router,
    private vendorTypeService: VendorTypeService,
    @Inject('BASE_URL') private baseUrl: string) { super(); }

  ngOnInit() {
    this.form = new FormGroup({
      description: new FormControl('', Validators.required)
    }, null, this.isDuplicate());
    this.loadData();
  }

  loadData() {
    this.vendorTypeId = +this.activatedRoute.snapshot.paramMap.get("vendorTypeId");

    if (this.vendorTypeId) {
      //EDIT MODE
      this.vendorTypeService.get<VendorType>(this.vendorTypeId)
        .subscribe(result => {
          this.vendorType = result;
          this.title = "Edit " + this.vendorType.description;

          this.form.patchValue(this.vendorType);
        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = 'Create a new Vendor Type';
    }
  }

  isDuplicate(): AsyncValidatorFn {
    return (control: AbstractControl): Observable<{ [key: string]: any } | null> => {
      var vendorType = <VendorType>{};
      vendorType.vendorTypeId = (this.vendorTypeId) ? this.vendorTypeId : 0;
      vendorType.description = this.form.get("description").value;

      return this.vendorTypeService.isDuplicate(vendorType)
        .pipe(map(result => {
          return (result ? { isDuplicate: true } : null);
        }));
    }
  }

  onSubmit() {
    var vendorType = (this.vendorTypeId) ? this.vendorType : <VendorType>{};

    vendorType.description = this.form.get("description").value;

    if (this.vendorTypeId) {
      //EDIT MODE
      this.vendorTypeService.put<VendorType>(vendorType)
        .subscribe(result => {
          console.log("Vendor Type " + vendorType.vendorTypeId + " has been updated.");
          this.router.navigate(['/vendorTypes']);
        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.vendorTypeService.post<VendorType>(vendorType)
        .subscribe(result => {
          console.log("Vendor Type " + result.vendorTypeId + " has been created.");
          this.router.navigate(['/vendorTypes']);
        }, error => console.error(error));
    }
  }

  onDelete() {
    var vendorType = (this.vendorTypeId) ? this.vendorType : <VendorType>{};
    this.vendorTypeService.delete<VendorType>(this.vendorType.vendorTypeId)
      .subscribe(result => {
        console.log("Vendor Type " + vendorType.vendorTypeId + " has been deleted.");
        this.router.navigate(['/vendorTypes']);
      }, error => console.error(error));
  }

}
