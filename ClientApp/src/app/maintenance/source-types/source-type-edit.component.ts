import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

import { Source } from './source-Type';
import { SourceTypeService } from './source-type-service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ApiResult } from '../../base.service';
import { BaseFormComponent } from '../../base.form.component'

@Component({
  selector: 'app-source-type-edit',
  templateUrl: './source-type-edit.component.html',
  styleUrls: ['./source-type-edit.component.css', '../../../global.css']
})
export class SourceTypeEditComponent extends BaseFormComponent implements OnInit {

  title: string;
  form: FormGroup;
  source: Source;
  sourceId?: number;

  constructor(private activatedRoute: ActivatedRoute,
    private router: Router,
    private sourceTypeService: SourceTypeService,
    @Inject('BASE_URL') private baseUrl: string) { super(); }

  ngOnInit() {
    this.form = new FormGroup({
      sourceDesc: new FormControl('', Validators.required)
    }, null, this.isDuplicate());
    this.loadData();
  }

  loadData() {
    this.sourceId = +this.activatedRoute.snapshot.paramMap.get("sourceId");

    if (this.sourceId) {
      //EDIT MODE
      this.sourceTypeService.get<Source>(this.sourceId)
        .subscribe(result => {
          this.source = result;
          this.title = "Edit " + this.source.sourceDesc;

          this.form.patchValue(this.source);
        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = 'Create a new Payment Type';
    }
  }

  isDuplicate(): AsyncValidatorFn {
    return (control: AbstractControl): Observable<{ [key: string]: any } | null> => {
      var source = <Source>{};
      source.sourceId = (this.sourceId) ? this.sourceId : 0;
      source.sourceDesc = this.form.get("sourceDesc").value;

      return this.sourceTypeService.isDuplicate(source)
        .pipe(map(result => {
          return (result ? { isDuplicate: true } : null);
        }));
    }
  }

  onSubmit() {
    var source = (this.sourceId) ? this.source : <Source>{};

    source.sourceDesc = this.form.get("sourceDesc").value;

    if (this.sourceId) {
      //EDIT MODE
      this.sourceTypeService.put<Source>(source)
        .subscribe(result => {
          console.log("Source Type " + source.sourceId + " has been updated.");
          this.router.navigate(['/sources']);
        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.sourceTypeService.post<Source>(source)
        .subscribe(result => {
          console.log("Source Type " + result.sourceId + " has been created.");
          this.router.navigate(['/sources']);
        }, error => console.error(error));
    }
  }

  onDelete() {
    var source = (this.sourceId) ? this.source : <Source>{};
    this.sourceTypeService.delete<Source>(this.source.sourceId)
      .subscribe(result => {
        console.log("Source Type " + source.sourceId + " has been deleted.");
        this.router.navigate(['/sources']);
      }, error => console.error(error));
  }

}
