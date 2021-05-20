import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { formatDate, DatePipe } from '@angular/common';
import { NgbDateStruct, NgbDate, NgbDateAdapter, NgbDateNativeAdapter} from '@ng-bootstrap/ng-bootstrap';

import { Meeting } from './meeting';
import { MeetingService } from './meeting-service';
import { CompanyService } from './../companies/company.service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';

import { ApiResult } from '../base.service';
import { BaseFormComponent } from '../base.form.component'
import { Company } from '../companies/company';

@Component({
  selector: 'app-meeting-edit',
  templateUrl: './meeting-edit.component.html',
  styleUrls: ['./meeting-edit.component.css', '../../global.css'],
  providers: [DatePipe]
})
export class MeetingEditComponent extends BaseFormComponent implements OnInit {

  //for date picker
  model: NgbDateStruct;
  //date: { year: number, month: number, day: number };

  title: string;
  form: FormGroup;
  meeting: Meeting;
  meetingCode?: string;
  companies: Company[];

  constructor(private activatedRoute: ActivatedRoute,
    private router: Router,
    private meetingService: MeetingService,
    private companyService: CompanyService,
    private datePipe: DatePipe,
    @Inject('BASE_URL') private baseUrl: string) { super(); }

  ngOnInit() {
    this.form = new FormGroup({
      meetingCode: new FormControl('', Validators.required),
      meetingDesc: new FormControl('', Validators.required),
      meetingStartDate: new FormControl('', Validators.required),
      meetingStartTime: new FormControl('', Validators.required),
      meetingEndDate: new FormControl('', Validators.required),
      meetingEndTime: new FormControl('', Validators.required),
      longDescription: new FormControl('', Validators.required),
      meetingLocation: new FormControl('', Validators.required),
      meetingInstructions: new FormControl(''),
      etrakMeetingImage: new FormControl(''),
      earlyCancellationAmt: new FormControl(''),
      cancellationDate: new FormControl(''),
      lateCancellationAmt: new FormControl(''),
      sponsor: new FormControl(''),
      meetingDetailUrl: new FormControl(''),
      gmtOffset: new FormControl(''),
      allowWebReg: new FormControl(''),
      allowWebGuests: new FormControl(''),
      webSortOrder: new FormControl(''),
      sponsoredBy: new FormControl('')
    }, null, this.isDuplicate());
    this.loadData();
  }

  loadData() {
    //load companies into sponsored by dropdown
    this.loadSponsoredBy();

    this.meetingCode = this.activatedRoute.snapshot.paramMap.get("id");
    
    if (this.meetingCode) {
      //EDIT MODE
      this.meetingService.get<Meeting>(this.meetingCode)
        .subscribe(result => {
          this.meeting = result;
          this.title = "Edit " + this.meeting.meetingCode;

          this.form.patchValue(this.meeting);

          //Date picker needs JSON values for year, month, and day
          const startYear = Number(this.datePipe.transform(this.meeting.meetingStartDate, 'yyyy'));
          const startMonth = Number(this.datePipe.transform(this.meeting.meetingStartDate, 'MM'));
          const startDay = Number(this.datePipe.transform(this.meeting.meetingStartDate, 'dd'));
          
          this.form.get('meetingStartDate').setValue({
            year: startYear,
            month: startMonth,
            day: startDay
          });

          const endYear = Number(this.datePipe.transform(this.meeting.meetingEndDate, 'yyyy'));
          const endMonth = Number(this.datePipe.transform(this.meeting.meetingEndDate, 'MM'));
          const endDay = Number(this.datePipe.transform(this.meeting.meetingEndDate, 'dd'));

          this.form.get('meetingEndDate').setValue({
            year: endYear,
            month: endMonth,
            day: endDay
          });

          const cancelYear = Number(this.datePipe.transform(this.meeting.cancellationDate, 'yyyy'));
          const cancelMonth = Number(this.datePipe.transform(this.meeting.cancellationDate, 'MM'));
          const cancelDay = Number(this.datePipe.transform(this.meeting.cancellationDate, 'dd'));

          this.form.get('cancellationDate').setValue({
            year: cancelYear,
            month: cancelMonth,
            day: cancelDay
          });

          this.form.controls.meetingStartTime.setValue(formatDate(this.meeting.meetingStartTime, "shortTime", "en-US"));
          this.form.controls.meetingEndTime.setValue(formatDate(this.meeting.meetingEndTime, "shortTime", "en-US"));

        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = 'Create a new Meeting';
    }
  }

  loadSponsoredBy() {
    this.companyService.getData<ApiResult<Company>>(0, 9999, "companyName", "asc", null, null)
      .subscribe(result => {
        this.companies = result.data;
      },
        error => console.log(error));
  }

  isDuplicate(): AsyncValidatorFn {
    return (control: AbstractControl): Observable<{ [key: string]: any } | null> => {
      var meeting = <Meeting>{};
      meeting.meetingCode = (this.meetingCode) ? this.meetingCode : null;
      //meeting.description = this.form.get("description").value;

      return this.meetingService.isDuplicate(meeting)
        .pipe(map(result => {
          return (result ? { isDuplicate: true } : null);
        }));
    }
  }

  onSubmit() {
    var meeting = (this.meetingCode) ? this.meeting : <Meeting>{};

    meeting.meetingDesc = this.form.get("meetingDesc").value;
    meeting.meetingStartDate = this.form.get("meetingStartDate").value;
    meeting.meetingStartTime = this.form.get("meetingStartTime").value;
    meeting.meetingEndDate = this.form.get("meetingEndDate").value;
    meeting.meetingEndTime = this.form.get("meetingEndTime").value;
    meeting.longDescription = this.form.get("longDescription").value;
    meeting.meetingLocation = this.form.get("meetingLocation").value;
    meeting.meetingInstructions = this.form.get("meetingInstructions").value;
    meeting.etrakMeetingImage = this.form.get("etrakMeetingImage").value;
    meeting.earlyCancellationAmt = this.form.get("earlyCancellationAmt").value;
    meeting.cancellationDate = this.form.get("cancellationDate").value;
    meeting.lateCancellationAmt = this.form.get("lateCancellationAmt").value;
    meeting.sponsor = this.form.get("sponsor").value;
    meeting.meetingDetailUrl = this.form.get("meetingDetailUrl").value;
    meeting.gmtOffset = this.form.get("gmtOffset").value;
    meeting.allowWebReg = this.form.get("allowWebReg").value;
    meeting.allowWebGuests = this.form.get("allowWebGuests").value;
    meeting.webSortOrder = this.form.get("webSortOrder").value
    meeting.useHousingCosts = false;    //this will always be false; the field is not used but the value is required on the database table
    meeting.useItineraryCosts = false;  //this will always be false; the field is not used but the value is required on the database table
    meeting.sponsoredBy = +this.form.get("sponsoredBy").value;

    if (this.meetingCode) {
      //EDIT MODE
      this.meetingService.put<Meeting>(meeting)
        .subscribe(result => {
          console.log("Meeting " + meeting.meetingCode + " has been updated.");
          this.router.navigate(['/meetings']);
        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.meetingService.post<Meeting>(meeting)
        .subscribe(result => {
          console.log("Meeting " + result.meetingCode + " has been created.");
          this.router.navigate(['/meetings']);
        }, error => console.error(error));
    }
  }

  onDelete() {
    var meeting = (this.meetingCode) ? this.meetingCode : <Meeting>{};
    this.meetingService.delete<Meeting>(this.meeting.meetingCode)
      .subscribe(result => {
        console.log("Meeting " + this.meeting.meetingCode + " has been deleted.");
        this.router.navigate(['/meetings']);
      }, error => console.error(error));
  }

}
