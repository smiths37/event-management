import { Component, OnInit, Inject } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';

import { Exhibitor } from './exhibitor';
import { ExhibitorService } from './exhibitor.service';

import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ApiResult } from '../base.service';
import { BaseFormComponent } from '../base.form.component'
import { formatCurrency, DatePipe } from '@angular/common';
import { NgbDateStruct } from '@ng-bootstrap/ng-bootstrap';

import { Company } from '../companies/company';
import { CompanyService } from './../companies/company.service';
import { Source } from '../maintenance/source-types/source-type';
import { SourceTypeService } from '../maintenance/source-types/source-type-service';
import { Meeting } from '../meetings/meeting';
import { MeetingService } from '../meetings/meeting-service';
import { Person } from '../people/person';
import { PersonService } from '../people/person.service';


@Component({
  selector: 'app-exhibitor-edit',
  templateUrl: './exhibitor-edit.component.html',
  styleUrls: ['./exhibitor-edit.component.css'],
  providers: [DatePipe]
})
export class ExhibitorEditComponent extends BaseFormComponent implements OnInit {
  model: NgbDateStruct;
  title: string;
  form: FormGroup;
  exhibitor: Exhibitor;
  exhibitorId?: number;
  companyId?: number;
  meetingCode?: string;
  totalCost: number;
  balanceDue: number;

  meetings: Meeting[];
  companies: Company[];
  sources: Source[];
  companyPeople: Person[];

  constructor(
    private activatedRoute: ActivatedRoute,
    private router: Router,
    private http: HttpClient,
    private exhibitorService: ExhibitorService,
    private companyService: CompanyService,
    private meetingService: MeetingService,
    private personService: PersonService,
    private sourceService: SourceTypeService,
    private datePipe: DatePipe,
    @Inject('BASE_URL') private baseUrl: string
  ) { super();}

  ngOnInit() {
    this.form = new FormGroup({
      meetingCode: new FormControl('', Validators.required),
      meetingDesc: new FormControl(''),   //readonly field
      companyName: new FormControl('', Validators.required),
      companyId: new FormControl(''), //readonly field
      personName: new FormControl(''),
      sourceDesc: new FormControl(''),
      numberOfBooths: new FormControl(''),
      costPerBooth: new FormControl(''),
      totalCost: new FormControl(''),
      boothLoc1: new FormControl(''),
      boothLoc2: new FormControl(''),
      boothLoc3: new FormControl(''),
      boothLoc4: new FormControl(''),
      depositReceived: new FormControl(''),
      depositAmount: new FormControl(''),
      balanceDue: new FormControl(''),
      confirmationSent: new FormControl(''),
      sponsoredEvents: new FormControl(''),
      profile: new FormControl('')
    }, null);
    this.loadData();
  }

  loadData() {
    this.loadMeetingCodes();
    this.loadCompanies();
    this.loadSources();

    this.companyId = +this.activatedRoute.snapshot.paramMap.get("companyId");
    this.meetingCode = this.activatedRoute.snapshot.paramMap.get("meetingCode");

    if (this.companyId && this.meetingCode) {
      //EDIT MODE
      this.exhibitorService.getExhibitorByCompanyAndMeeting<Exhibitor>(this.companyId, this.meetingCode)
        .subscribe(result => {
          this.exhibitor = result;
          this.title = "Edit Exhibitor for " + this.exhibitor.meetingCode; 

          this.exhibitorId = this.exhibitor.exhibitorId;
          this.exhibitor.meetingDesc

          this.form.patchValue(this.exhibitor);

          //Set dropddown values
          this.form.get('companyName').setValue(this.exhibitor.companyId);
          this.form.get('sourceDesc').setValue(this.exhibitor.sourceId);
          this.form.get("personName").setValue(this.exhibitor.personId);         

          this.form.get('meetingCode')
          //Set calculated values
          this.totalCost = this.exhibitor.numberOfBooths * this.exhibitor.costPerBooth;
          this.balanceDue = this.totalCost - this.exhibitor.depositAmount;

          //format currency fields
          this.form.get('totalCost').setValue(formatCurrency((this.totalCost), "en-us", "$"));
          this.form.get('balanceDue').setValue(formatCurrency((this.balanceDue), "en-us", "$"));

          //load company people now that we know the companyId
          this.loadCompanyPeople(this.exhibitor.companyId);

          //Date picker needs JSON values for year, month, and day
          const depositYear = Number(this.datePipe.transform(this.exhibitor.depositReceived, 'yyyy'));
          const depositMonth = Number(this.datePipe.transform(this.exhibitor.depositReceived, 'MM'));
          const depositDay = Number(this.datePipe.transform(this.exhibitor.depositReceived, 'dd'));

          this.form.get('depositReceived').setValue({
            year: depositYear,
            month: depositMonth,
            day: depositDay
          });

          const confirmYear = Number(this.datePipe.transform(this.exhibitor.confirmationSent, 'yyyy'));
          const confirmMonth = Number(this.datePipe.transform(this.exhibitor.confirmationSent, 'MM'));
          const confirmDay = Number(this.datePipe.transform(this.exhibitor.confirmationSent, 'dd'));

          this.form.get('confirmationSent').setValue({
            year: confirmYear,
            month: confirmMonth,
            day: confirmDay
          });

        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = 'Create a new Exhibitor';
    }
  }

  loadMeetingCodes() {
    this.meetingService.getData<ApiResult<Meeting>>(0, 9999, "meetingCode", "asc", null, null)
      .subscribe(result => {
        this.meetings = result.data;
        this.form.get("meetingDesc").setValue(this.meetings.find(x => x.meetingCode == this.exhibitor.meetingCode).meetingDesc);
      },
        error => console.log(error));
    
  }

  loadCompanies() {
    this.companyService.getData<ApiResult<Company>>(0, 9999, "companyName", "asc", null, null)
      .subscribe(result => {
        this.companies = result.data;
      },
        error => console.log(error));
  }

  loadSources() {
    this.sourceService.getData<ApiResult<Source>>(0, 9999, "sourceDesc", "asc", null, null)
      .subscribe(result => {
        this.sources = result.data;
      },
        error => console.log(error));
  }

  onCompanySelected(object) {
    this.form.get('companyId').setValue(this.form.get("companyName").value);

    //Load the new company's people into the peopleName dropdown
    this.loadCompanyPeople(object.value);
  }

  onMeetingCodeSelected(object) {
    this.form.get("meetingDesc").setValue(this.meetings.find(x => x.meetingCode == object.value).meetingDesc);
  }

  calculateTotalAndBalance(object) {
    //Calculate new total cost and balance due and re-format as currency - done after number of booths, cost per booth, or deposit amount changes
    this.totalCost = (this.form.get('numberOfBooths').value) * (this.form.get('costPerBooth').value);
    this.form.get('totalCost').setValue(formatCurrency(this.totalCost,"en-us", "$"));
    this.form.get('balanceDue').setValue(formatCurrency((this.totalCost) - (this.form.get('depositAmount').value), "en-us", "$"));
  }

  loadCompanyPeople(companyId) {
    var url = this.baseUrl + 'api/Companies/getCompanyPeople/' + companyId;

    this.http.get<any>(url)
      .subscribe(result => {
        this.companyPeople = result;
      }, error => console.error(error));
  }

  onSubmit() {
    //this.exhibitorId = +this.activatedRoute.snapshot.paramMap.get('exhibitorId');
    //this.companyId = +this.activatedRoute.snapshot.paramMap.get("companyId");
    //this.meetingCode = this.activatedRoute.snapshot.paramMap.get("meetingCode");

    var exhibitor = (this.companyId && this.meetingCode) ? this.exhibitor : <Exhibitor>{};

    exhibitor.companyId = +this.form.get("companyId").value;    
    exhibitor.meetingCode = this.form.get("meetingCode").value;

    //Check for blank values on non-required fields. Skip totalCost and balanceDue - those are calculated fields
    this.form.get("personName").value == "" ? exhibitor.personId = null : exhibitor.personId = +this.form.get("personName").value;
    this.form.get("numberOfBooths").value == "" ? exhibitor.numberOfBooths = null : exhibitor.numberOfBooths = this.form.get("numberOfBooths").value;
    this.form.get("costPerBooth").value == "" ? exhibitor.costPerBooth = null : exhibitor.costPerBooth = this.form.get("costPerBooth").value;
    this.form.get("depositAmount").value == "" ? exhibitor.depositAmount = null : exhibitor.depositAmount = this.form.get("depositAmount").value;
    this.form.get("boothLoc1").value == "" ? exhibitor.boothLoc1 = null : exhibitor.boothLoc1 = this.form.get("boothLoc1").value;
    this.form.get("boothLoc2").value == "" ? exhibitor.boothLoc2 = null : exhibitor.boothLoc2 = this.form.get("boothLoc2").value;
    this.form.get("boothLoc3").value == "" ? exhibitor.boothLoc3 = null : exhibitor.boothLoc3 = this.form.get("boothLoc3").value;
    this.form.get("boothLoc4").value == "" ? exhibitor.boothLoc4 = null : exhibitor.boothLoc4 = this.form.get("boothLoc4").value;
    this.form.get("sponsoredEvents").value == "" ? exhibitor.sponsoredEvents = null : exhibitor.sponsoredEvents = this.form.get("sponsoredEvents").value;
    this.form.get("depositReceived").value == "" ? exhibitor.depositReceived = null : exhibitor.depositReceived = this.form.get("depositReceived").value;
    this.form.get("confirmationSent").value == "" ? exhibitor.confirmationSent = null : exhibitor.confirmationSent = this.form.get("confirmationSent").value;
    this.form.get("profile").value == "" ? exhibitor.profile = null : exhibitor.profile = this.form.get("profile").value;
    this.form.get("sourceDesc").value == "" ? exhibitor.sourceId = null : exhibitor.sourceId = this.form.get("sourceDesc").value;

    if (this.companyId && this.meetingCode) {
      //EDIT MODE
      this.exhibitorService.put<Exhibitor>(exhibitor)
        .subscribe(result => {
          console.log("Exhibitor " + exhibitor.exhibitorId + " has been updated.");
          this.router.navigate(['/exhibitors']);
        }, error => console.log(error));
    } else {
      //ADD NEW MODE
      this.exhibitorService.post<Exhibitor>(exhibitor)
        .subscribe(result => {
          console.log("Exhibitor " + exhibitor.exhibitorId + " has been created.");
          this.router.navigate(['/exhibitors']);
        }, error => console.log(error));
    }
  }

  onDelete() {
    //var exhibitor = (this.exhibitorId) ? this.exhibitor : <Exhibitor>{};
    var exhibitor = (this.companyId && this.meetingCode) ? this.exhibitor : <Exhibitor>{};

    this.exhibitorService.deleteExhibitorByCompanyAndMeeting<Exhibitor>(exhibitor.companyId, exhibitor.meetingCode)
      .subscribe(result => {
        console.log("Exhibitor " + exhibitor.exhibitorId + " has been deleted.");
        this.router.navigate(['/exhibitors']);
      }, error => console.error(error));
  }
}
