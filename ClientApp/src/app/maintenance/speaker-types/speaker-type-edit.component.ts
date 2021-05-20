import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

import { SpeakerType } from './speaker-Type';
import { SpeakerTypeService } from './speaker-type-service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ApiResult } from '../../base.service';
import { BaseFormComponent } from '../../base.form.component'

@Component({
  selector: 'app-speaker-type-edit',
  templateUrl: './speaker-type-edit.component.html',
  styleUrls: ['./speaker-type-edit.component.css', '../../../global.css']
})
export class SpeakerTypeEditComponent extends BaseFormComponent implements OnInit {

  title: string;
  form: FormGroup;
  speakerType: SpeakerType;
  speakerTypeId?: number;

  constructor(private activatedRoute: ActivatedRoute,
    private router: Router,
    private speakerTypeService: SpeakerTypeService,
    @Inject('BASE_URL') private baseUrl: string) { super(); }

  ngOnInit() {
    this.form = new FormGroup({
      speakerTypeDesc: new FormControl('', Validators.required)
    }, null, this.isDuplicate());
    this.loadData();
  }

  loadData() {
    this.speakerTypeId = +this.activatedRoute.snapshot.paramMap.get("speakerTypeId");

    if (this.speakerTypeId) {
      //EDIT MODE
      this.speakerTypeService.get<SpeakerType>(this.speakerTypeId)
        .subscribe(result => {
          this.speakerType = result;
          this.title = "Edit " + this.speakerType.speakerTypeDesc;

          this.form.patchValue(this.speakerType);
        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = 'Create a new Speaker Type';
    }
  }

  isDuplicate(): AsyncValidatorFn {
    return (control: AbstractControl): Observable<{ [key: string]: any } | null> => {
      var speakerType = <SpeakerType>{};
      speakerType.speakerTypeId = (this.speakerTypeId) ? this.speakerTypeId : 0;
      speakerType.speakerTypeDesc = this.form.get("speakerTypeDesc").value;

      return this.speakerTypeService.isDuplicate(speakerType)
        .pipe(map(result => {
          return (result ? { isDuplicate: true } : null);
        }));
    }
  }

  onSubmit() {
    var speakerType = (this.speakerTypeId) ? this.speakerType : <SpeakerType>{};

    speakerType.speakerTypeDesc = this.form.get("speakerTypeDesc").value;

    if (this.speakerTypeId) {
      //EDIT MODE
      this.speakerTypeService.put<SpeakerType>(speakerType)
        .subscribe(result => {
          console.log("Speaker Type " + speakerType.speakerTypeId + " has been updated.");
          this.router.navigate(['/speakerTypes']);
        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.speakerTypeService.post<SpeakerType>(speakerType)
        .subscribe(result => {
          console.log("speaker Type " + result.speakerTypeId + " has been created.");
          this.router.navigate(['/speakerTypes']);
        }, error => console.error(error));
    }
  }

  onDelete() {
    var speakerType = (this.speakerTypeId) ? this.speakerType : <SpeakerType>{};
    this.speakerTypeService.delete<SpeakerType>(this.speakerType.speakerTypeId)
      .subscribe(result => {
        console.log("Speaker Type " + speakerType.speakerTypeId + " has been deleted.");
        this.router.navigate(['/speakerTypes']);
      }, error => console.error(error));
  }

}
