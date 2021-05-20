import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
//import { HttpClient, HttpParams } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { PaymentMethod } from './payment-method';
import { PaymentMethodService } from './payment-methods.service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ApiResult } from '../../base.service';
import { BaseFormComponent } from '../../base.form.component'

@Component({
  selector: 'app-payment-method-edit',
  templateUrl: './payment-method-edit.component.html',
  styleUrls: ['./payment-method-edit.component.css', '../../../global.css']
})
export class PaymentMethodEditComponent extends BaseFormComponent implements OnInit {
  title: string;
  form: FormGroup;
  paymentMethod: PaymentMethod;
  paymentMethodId?: number;

  constructor(private activatedRoute: ActivatedRoute,
    private router: Router,
    //private http: HttpClient,
    private paymentMethodService: PaymentMethodService,
    @Inject('BASE_URL') private baseUrl: string) { super(); }

  ngOnInit() {
    this.form = new FormGroup({
      paymentMethodDesc: new FormControl('', Validators.required),
      allowOnWeb: new FormControl('')
    }, null, this.isDuplicate());
    this.loadData();
  }

  loadData() {
    this.paymentMethodId = +this.activatedRoute.snapshot.paramMap.get("paymentMethodId");

    if (this.paymentMethodId) {
      //EDIT MODE
      //var url = this.baseUrl + "api/paymentMethods/" + this.paymentMethodId;
      //this.http.get<PaymentMethod>(url)
      this.paymentMethodService.get<PaymentMethod>(this.paymentMethodId)
        .subscribe(result => {
        this.paymentMethod = result;
        this.title = "Edit " + this.paymentMethod.paymentMethodDesc;

        this.form.patchValue(this.paymentMethod);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = 'Create a new Payment Method';
    }
  }

  isDuplicate(): AsyncValidatorFn {
    return (control: AbstractControl): Observable<{ [key: string]: any } | null> => {
      var paymentMethod = <PaymentMethod>{};
      paymentMethod.paymentMethodId = (this.paymentMethodId) ? this.paymentMethodId : 0;
      paymentMethod.paymentMethodDesc = this.form.get("paymentMethodDesc").value;

      //var url = this.baseUrl + "api/paymentMethods/IsDuplicate";
      //return this.http.post<boolean>(url, paymentMethod)
      return this.paymentMethodService.isDuplicate(paymentMethod)
        .pipe(map(result => {
        return (result ? { isDuplicate: true } : null);
      }));
    }
  }

  onSubmit() {
    var paymentMethod = (this.paymentMethodId) ? this.paymentMethod : <PaymentMethod>{};

    paymentMethod.paymentMethodDesc = this.form.get("paymentMethodDesc").value;

    if (this.form.controls["allowOnWeb"].value == "" || this.form.controls["allowOnWeb"].value == null) {
      paymentMethod.allowOnWeb = false;
    } else {
      paymentMethod.allowOnWeb = true;
    }

    if (this.paymentMethodId) {
      //EDIT MODE
      //var url = this.baseUrl + "api/paymentMethods/" + this.paymentMethod.paymentMethodId;
      //this.http.put<PaymentMethod>(url, paymentMethod)
      this.paymentMethodService.put<PaymentMethod>(paymentMethod)
        .subscribe(result => {
          console.log("Payment Method " + paymentMethod.paymentMethodId + " has been updated.");
        this.router.navigate(['/paymentMethods']);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      //var url = this.baseUrl = "api/paymentMethods";
      //this.http.post<PaymentMethod>(url, paymentMethod)
      this.paymentMethodService.post<PaymentMethod>(paymentMethod)
        .subscribe(result => {
          console.log("Payment Method " + result.paymentMethodId + " has been created.");
        this.router.navigate(['/paymentMethods']);
      }, error => console.error(error));
    }
  }

  onDelete() {
    var paymentMethod = (this.paymentMethodId) ? this.paymentMethod : <PaymentMethod>{};
    //var url = this.baseUrl = 'api/paymentMethods/' + this.paymentMethod.paymentMethodId;
    //this.http.delete<PaymentMethod>(url)
    this.paymentMethodService.delete<PaymentMethod>(this.paymentMethod.paymentMethodId)
      .subscribe(result => {
      console.log("Payment Method " + paymentMethod.paymentMethodId + " has been deleted.");
      this.router.navigate(['/paymentMethods']);
    }, error => console.error(error));
  }
}
