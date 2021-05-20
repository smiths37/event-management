import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
//import { HttpClient, HttpParams } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { FbItem } from './fb-items';
import { FBItemsService } from './fb-tems.service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ApiResult } from '../../base.service';
import { BaseFormComponent } from '../../base.form.component'

@Component({
  selector: 'app-food-and-beverage-edit',
  templateUrl: './food-and-beverage-edit.component.html',
  styleUrls: ['./food-and-beverage-edit.component.css', '../../../global.css']
})
export class FoodAndBeverageEditComponent extends BaseFormComponent implements OnInit {
  title: string;
  form: FormGroup;
  fbItem: FbItem;
  fbId?: number;

  constructor(
    private activatedRoute: ActivatedRoute,
    private router: Router,
    //private http: HttpClient,
    private fbItemService: FBItemsService,
    @Inject('BASE_URL') private baseUrl: string) { super(); }

  ngOnInit() {
    this.form = new FormGroup({
      fbDesc: new FormControl('', Validators.required)
    }, null, this.isDuplicate());
    this.loadData();
  }

  loadData() {
    this.fbId = +this.activatedRoute.snapshot.paramMap.get("fbId");

    if (this.fbId) {
      //EDIT MODE
      //var url = this.baseUrl + "api/FoodAndBeverage/" + this.fbId;
      //this.http.get<FbItem>(url)
      this.fbItemService.get<FbItem>(this.fbId)
        .subscribe(result => {
        this.fbItem = result;
        this.title = "Edit " + this.fbItem.fbDesc;

        this.form.patchValue(this.fbItem);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = 'Create a new Food and Beverage Item';
    }
  }

  isDuplicate(): AsyncValidatorFn {
    return (control: AbstractControl): Observable<{ [key: string]: any } | null> => {
      var fbItem = <FbItem>{};
      fbItem.fbId = (this.fbId) ? this.fbId : 0;
      fbItem.fbDesc = this.form.get("fbDesc").value;

      //var url = this.baseUrl + "api/FoodAndBeverage/IsDuplicate";
      //return this.http.post<boolean>(url, fbItem)
      return this.fbItemService.isDuplicate(fbItem)
        .pipe(map(result => {
        return (result ? { isDuplicate: true } : null);
      }));
    }
  }

  onSubmit() {
    var fbItem = (this.fbId) ? this.fbItem : <FbItem>{};

    fbItem.fbDesc = this.form.get("fbDesc").value;

    if (this.fbId) {
      //EDIT MODE
      //var url = this.baseUrl + "api/FoodAndBeverage/" + this.fbItem.fbId;
      //this.http.put<FbItem>(url, fbItem)
      this.fbItemService.put<FbItem>(fbItem)
        .subscribe(result => {
        console.log("Food and Beverage Item " + fbItem.fbId + " has been updated.");
        this.router.navigate(['/fbItems']);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      //var url = this.baseUrl = "api/FoodAndBeverage";
      //this.http.post<FbItem>(url, fbItem)
      this.fbItemService.post<FbItem>(fbItem)
        .subscribe(result => {
        console.log("Food and Beverage Item " + result.fbId + " has been created.");
        this.router.navigate(['/fbItems']);
      }, error => console.error(error));
    }
  }

  onDelete() {
    var fbItem = (this.fbId) ? this.fbItem : <FbItem>{};
    //var url = this.baseUrl = 'api/FoodAndBeverage/' + this.fbItem.fbId;
    //this.http.delete<FbItem>(url)
    this.fbItemService.delete<FbItem>(this.fbItem.fbId)
      .subscribe(result => {
      console.log("Food and Beverage Item " + fbItem.fbId + " has been deleted.");
      this.router.navigate(['/fbItems']);
    }, error => console.error(error));
  }

}
