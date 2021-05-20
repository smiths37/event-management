import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

import { PaymentType } from './payment-Type';
import { PaymentTypeService } from './payment-type-service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ApiResult } from '../../base.service';
import { BaseFormComponent } from '../../base.form.component'

@Component({
  selector: 'app-payment-Type-edit',
  templateUrl: './payment-Type-edit.component.html',
  styleUrls: ['./payment-Type-edit.component.css', '../../../global.css']
})
export class PaymentTypeEditComponent extends BaseFormComponent implements OnInit {
  title: string;
  form: FormGroup;
  paymentType: PaymentType;
  paymentTypeId?: number;

  constructor(private activatedRoute: ActivatedRoute,
    private router: Router,
    private paymentTypeService: PaymentTypeService,
    @Inject('BASE_URL') private baseUrl: string) { super(); }

  ngOnInit() {
    this.form = new FormGroup({
      paymentTypeDesc: new FormControl('', Validators.required)
    }, null, this.isDuplicate());
    this.loadData();
  }

  loadData() {
    this.paymentTypeId = +this.activatedRoute.snapshot.paramMap.get("paymentTypeId");

    if (this.paymentTypeId) {
      //EDIT MODE
      this.paymentTypeService.get<PaymentType>(this.paymentTypeId)
        .subscribe(result => {
          this.paymentType = result;
          this.title = "Edit " + this.paymentType.paymentTypeDesc;

          this.form.patchValue(this.paymentType);
        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = 'Create a new Payment Type';
    }
  }

  isDuplicate(): AsyncValidatorFn {
    return (control: AbstractControl): Observable<{ [key: string]: any } | null> => {
      var paymentType = <PaymentType>{};
      paymentType.paymentTypeId = (this.paymentTypeId) ? this.paymentTypeId : 0;
      paymentType.paymentTypeDesc = this.form.get("paymentTypeDesc").value;

      return this.paymentTypeService.isDuplicate(paymentType)
        .pipe(map(result => {
          return (result ? { isDuplicate: true } : null);
        }));
    }
  }

  onSubmit() {
    var paymentType = (this.paymentTypeId) ? this.paymentType : <PaymentType>{};

    paymentType.paymentTypeDesc = this.form.get("paymentTypeDesc").value;
    
    if (this.paymentTypeId) {
      //EDIT MODE
      this.paymentTypeService.put<PaymentType>(paymentType)
        .subscribe(result => {
          console.log("Payment Type " + paymentType.paymentTypeId + " has been updated.");
          this.router.navigate(['/paymentTypes']);
        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.paymentTypeService.post<PaymentType>(paymentType)
        .subscribe(result => {
          console.log("Payment Type " + result.paymentTypeId + " has been created.");
          this.router.navigate(['/paymentTypes']);
        }, error => console.error(error));
    }
  }

  onDelete() {
    var paymentType = (this.paymentTypeId) ? this.paymentType : <PaymentType>{};
    this.paymentTypeService.delete<PaymentType>(this.paymentType.paymentTypeId)
      .subscribe(result => {
        console.log("Payment Type " + paymentType.paymentTypeId + " has been deleted.");
        this.router.navigate(['/paymentTypes']);
      }, error => console.error(error));
  }
}
