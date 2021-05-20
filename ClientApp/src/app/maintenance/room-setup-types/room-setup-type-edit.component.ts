import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

import { RoomSetup } from './room-setup-type';
import { RoomSetupTypeService } from './room-setup-type-service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ApiResult } from '../../base.service';
import { BaseFormComponent } from '../../base.form.component'

@Component({
  selector: 'app-room-setup-type-edit',
  templateUrl: './room-setup-type-edit.component.html',
  styleUrls: ['./room-setup-type-edit.component.css', '../../../global.css']
})
export class RoomSetupTypeEditComponent extends BaseFormComponent implements OnInit {

  title: string;
  form: FormGroup;
  roomSetup: RoomSetup;
  setupId?: number;

  constructor(private activatedRoute: ActivatedRoute,
    private router: Router,
    private roomSetupTypeService: RoomSetupTypeService,
    @Inject('BASE_URL') private baseUrl: string) { super(); }

  ngOnInit() {
    this.form = new FormGroup({
      setupDesc: new FormControl('', Validators.required)
    }, null, this.isDuplicate());
    this.loadData();
  }

  loadData() {
    this.setupId = +this.activatedRoute.snapshot.paramMap.get("setupId");

    if (this.setupId) {
      //EDIT MODE
      this.roomSetupTypeService.get<RoomSetup>(this.setupId)
        .subscribe(result => {
          this.roomSetup = result;
          this.title = "Edit " + this.roomSetup.setupDesc;

          this.form.patchValue(this.roomSetup);
        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = 'Create a new Room Setup';
    }
  }

  isDuplicate(): AsyncValidatorFn {
    return (control: AbstractControl): Observable<{ [key: string]: any } | null> => {
      var roomSetup = <RoomSetup>{};
      roomSetup.setupId = (this.setupId) ? this.setupId : 0;
      roomSetup.setupDesc = this.form.get("setupDesc").value;

      return this.roomSetupTypeService.isDuplicate(roomSetup)
        .pipe(map(result => {
          return (result ? { isDuplicate: true } : null);
        }));
    }
  }

  onSubmit() {
    var roomSetup = (this.setupId) ? this.roomSetup : <RoomSetup>{};

    roomSetup.setupDesc = this.form.get("setupDesc").value;

    if (this.setupId) {
      //EDIT MODE
      this.roomSetupTypeService.put<RoomSetup>(roomSetup)
        .subscribe(result => {
          console.log("Room Setup Type " + roomSetup.setupId + " has been updated.");
          this.router.navigate(['/roomSetups']);
        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.roomSetupTypeService.post<RoomSetup>(roomSetup)
        .subscribe(result => {
          console.log("Room Setup Type " + result.setupId + " has been created.");
          this.router.navigate(['/roomSetups']);
        }, error => console.error(error));
    }
  }

  onDelete() {
    var roomSetup = (this.setupId) ? this.roomSetup : <RoomSetup>{};
    this.roomSetupTypeService.delete<RoomSetup>(this.roomSetup.setupId)
      .subscribe(result => {
        console.log("Room Setup Type " + roomSetup.setupId + " has been deleted.");
        this.router.navigate(['/roomSetups']);
      }, error => console.error(error));
  }

}
