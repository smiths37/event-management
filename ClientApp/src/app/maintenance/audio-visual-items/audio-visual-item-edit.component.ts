import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
//import { HttpClient, HttpParams } from '@angular/common/http';
import { ActivatedRoute, Router } from '@angular/router';

import { AudioVisualItem } from './audio-visual-items';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ApiResult } from '../../base.service';
import { BaseFormComponent } from '../../base.form.component'
import { AudioVisualItemsService } from './audio-visual-items.service';

@Component({
  selector: 'app-audio-visual-item-edit',
  templateUrl: './audio-visual-item-edit.component.html',
  styleUrls: ['./audio-visual-item-edit.component.css', '../../../global.css']
})
export class AudioVisualItemEditComponent extends BaseFormComponent implements OnInit {
  title: string;
  form: FormGroup;
  avItem: AudioVisualItem;
  avId?: number;

  constructor(
    private activatedRoute: ActivatedRoute,
    private router: Router,
    //private http: HttpClient,
    private avItemsService: AudioVisualItemsService,
    @Inject('BASE_URL') private baseUrl: string
  ) { super();}

  ngOnInit() {
    this.form = new FormGroup({
      avDesc: new FormControl('', Validators.required)
    }, null, this.isDuplicate());
    this.loadData();
  }

  loadData() {
    this.avId = +this.activatedRoute.snapshot.paramMap.get("avId");

    if (this.avId) {
      //EDIT MODE
      //var url = this.baseUrl + "api/AudioVisualItems/" + this.avId;
      //this.http.get<AudioVisualItem>(url)
      this.avItemsService.get<AudioVisualItem>(this.avId)
        .subscribe(result => {
        this.avItem = result;
        this.title = "Edit " + this.avItem.avDesc;

        this.form.patchValue(this.avItem);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = 'Create a new Audio Visual Item';
    }
  }

  isDuplicate(): AsyncValidatorFn {
    return (control: AbstractControl): Observable<{ [key: string]: any } | null> => {
      var avItem = <AudioVisualItem>{};
      avItem.avId = (this.avId) ? this.avId : 0;
      avItem.avDesc = this.form.get("avDesc").value;

      //var url = this.baseUrl + "api/AudioVisualItems/IsDuplicate";
      //return this.http.post<boolean>(url, avItem)
      return this.avItemsService.isDuplicate(avItem)
      .pipe(map(result => {
        return (result ? { isDuplicate: true } : null);
      }));
    }
  }


  onSubmit() {
    var avItem = (this.avId) ? this.avItem : <AudioVisualItem>{};

    avItem.avDesc = this.form.get("avDesc").value;

    if (this.avId) {
      //EDIT MODE
      //var url = this.baseUrl + "api/AudioVisualItems/" + this.avItem.avId;
      //this.http.put<AudioVisualItem>(url, avItem)
      this.avItemsService.put<AudioVisualItem>(this.avItem)
        .subscribe(result => {
        console.log("Audio Visual Item " + avItem.avId + " has been updated.");
        this.router.navigate(['/AudioVisualItems']);
      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      //var url = this.baseUrl = "api/AudioVisualItems";
      //this.http.post<AudioVisualItem>(url, avItem)
      this.avItemsService.post<AudioVisualItem>(avItem)
        .subscribe(result => {
        console.log("Audio Visual Item " + result.avId + " has been created.");
        this.router.navigate(['/AudioVisualItems']);
      }, error => console.error(error));
    }
  }

  onDelete() {
    var avItem = (this.avId) ? this.avItem : <AudioVisualItem>{};
    //var url = this.baseUrl = 'api/AudioVisualItems/' + this.avItem.avId;
    //this.http.delete<AudioVisualItem>(url)
    this.avItemsService.delete<AudioVisualItem>(avItem.avId)
      .subscribe(result => {
      console.log("Audio Visual Item " + avItem.avId + " has been deleted.");
      this.router.navigate(['/AudioVisualItems']);
    }, error => console.error(error));
  }

}
