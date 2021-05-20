import { Component, Inject, ViewChild, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { faEnvelope } from '@fortawesome/free-solid-svg-icons';

import { Person } from './person';
import { PersonService } from './person.service';
import { SourceTypeService } from '../maintenance/source-types/source-type-service';
import { PeopleTypeService } from '../maintenance/people-types/people-type-service';
import { ContactTypeService } from '../maintenance/contact-types/contact-types.service';
import { CompanyService } from '../companies/company.service';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ApiResult } from '../base.service';
import { BaseFormComponent } from '../base.form.component'
import { PeopleType } from '../maintenance/people-types/people-type';
import { ContactType } from '../maintenance/contact-types/contact-type';
import { Source } from '../maintenance/source-types/source-type';
import { Company } from '../companies/company';


@Component({
  selector: 'app-person-edit',
  templateUrl: './person-edit.component.html',
  styleUrls: ['./person-edit.component.css', '../../global.css']
})

export class PersonEditComponent extends BaseFormComponent implements OnInit {
  //****** TO DO: Need to figure out how to put the email address as the href on the a for the envelope icon
  faEnvelope = faEnvelope;

  title: string;
  form: FormGroup;
  person: Person;
  personId?: number;

  sources: Source[];
  peopleTypes: PeopleType[];
  contactTypes: ContactType[];
  companies: Company[];

  constructor(private activatedRoute: ActivatedRoute,
    private router: Router,
    private personService: PersonService,
    private peopleTypeService: PeopleTypeService,
    private contactTypeService: ContactTypeService,
    private sourceTypeService: SourceTypeService,
    private companyService: CompanyService,
    @Inject('BASE_URL') private baseUrl: string) { super(); }

  ngOnInit() {
    this.form = new FormGroup({
      ssn: new FormControl(''),
      namePrefix: new FormControl(''),
      firstName: new FormControl('', Validators.required),
      middleName: new FormControl(''),
      lastName: new FormControl('', Validators.required),
      nameSuffix: new FormControl(''),
      badgeName: new FormControl(''),
      companyName: new FormControl(''),
      title: new FormControl(''),
      dept: new FormControl(''),
      peopleType: new FormControl(''),
      salutation: new FormControl(''),
      contactType: new FormControl(''),
      email: new FormControl(''),
      source: new FormControl(''),
      doNotMail: new FormControl(''),
      mailPref: new FormControl(''),
      cellPhone: new FormControl(''),
      formalTitle: new FormControl('')
    }, null);
    this.loadData();
  }

  loadData() {
    //load company types, source types, people types, and companies
    this.loadContactTypes();
    this.loadPeopleTypes();
    this.loadSources();
    this.loadCompanies();

    this.personId = +this.activatedRoute.snapshot.paramMap.get('personId');

    if (this.personId) {
      //EDIT MODE
      var url = this.baseUrl + "api/people/" + this.personId;
      this.personService.get<Person>(this.personId)
        .subscribe(result => {
          this.person = result;
          this.title = "Edit " + this.person.firstName + " " + this.person.lastName;

          this.form.patchValue(this.person);

          console.log(this.person);

          //the above was not setting the dropdown field values, do this manually instead
          this.form.get('peopleType').setValue(this.person.peopleType);
          this.form.get('contactType').setValue(this.person.contactType);
          this.form.get('source').setValue(this.person.sourceId);
          this.form.get('companyName').setValue(this.person.companyId);
          this.form.get('mailPref').setValue(this.person.mailPref);
          console.log("Mail Pref Dropdown Value: " + this.form.get('mailPref').value);

        }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = "Add a new Person";
    }
  }

  loadCompanies() {
    this.companyService.getData<ApiResult<Company>>(0, 9999, "companyName", "asc", null, null)
      .subscribe(result => {
        this.companies = result.data;
      },
        error => console.log(error));
  }

  loadSources() {
    this.sourceTypeService.getData<ApiResult<Source>>(0, 9999, "sourceDesc", "asc", null, null)
      .subscribe(result => {
        this.sources = result.data;
      },
        error => console.log(error));
  }

  loadContactTypes() {
    this.contactTypeService.getData<ApiResult<ContactType>>(0, 9999, "contactTypeDesc", "asc", null, null)
      .subscribe(result => {
        this.contactTypes = result.data;
      }, error => console.log(error));
  }

  loadPeopleTypes() {
    this.peopleTypeService.getData<ApiResult<PeopleType>>(0, 9999, "peopleTypeDesc", "asc", null, null)
      .subscribe(result => {
        this.peopleTypes = result.data;
      }, error => console.log(error));
  }

  onSubmit() {
    this.personId = +this.activatedRoute.snapshot.paramMap.get('personId');

    var person = (this.personId) ? this.person : <Person>{};

    person.firstName = this.form.get("firstName").value;
    person.lastName = this.form.get("lastName").value;

    //Check for blank values on non-required fields. Skip totalCost and balanceDue - those are calculated fields
    this.form.get("ssn").value == "" ? person.ssn = null : person.ssn = this.form.get("ssn").value;
    this.form.get("namePrefix").value == "" ? person.namePrefix = null : person.namePrefix = this.form.get("namePrefix").value;
    this.form.get("middleName").value == "" ? person.middle = null : person.middle = this.form.get("middleName").value;
    this.form.get("nameSuffix").value == "" ? person.nameSuffix = null : person.nameSuffix = this.form.get("nameSuffix").value;
    this.form.get("badgeName").value == "" ? person.badgeName = null : person.badgeName = this.form.get("badgeName").value;
    //person.companyName = this.form.get("companyName").value;
    this.form.get("companyName").value == "" ? person.companyId = null : person.companyId = +this.form.get("companyName").value;
    this.form.get("title").value == "" ? person.title = null : person.title = this.form.get("title").value;
    this.form.get("dept").value == "" ? person.dept = null : person.dept = this.form.get("dept").value;
    this.form.get("peopleType").value == "" ? person.peopleType = null : person.peopleType = +this.form.get("peopleType").value;
    this.form.get("salutation").value == "" ? person.salutation = null : person.salutation = this.form.get("salutation").value;
    this.form.get("contactType").value == "" ? person.contactType = null : person.contactType = +this.form.get("contactType").value;
    this.form.get("email").value == "" ? person.email = null : person.email = this.form.get("email").value;
    this.form.get("source").value == "" ? person.sourceId = null : person.sourceId = +this.form.get("source").value;
    this.form.get("doNotMail").value == "" ? person.doNotMail = null : person.doNotMail = this.form.get("doNotMail").value;
    this.form.get('mailPref').value == "" ? person.mailPref = null : person.mailPref = this.form.get('mailPref').value;
    this.form.get("cellPhone").value == "" ? person.cellPhone = null : person.cellPhone = this.form.get("cellPhone").value;
    this.form.get("formalTitle").value == "" ? person.formalTitle = null : this.form.get("formalTitle").value;
    person.primaryContact = false;
    person.sellName = false;
    person.includeInDirectory = false;
    person.includeInMemDirectory = false;


    if (this.personId) {
      //EDIT MODE
      this.personService.put<Person>(person)
        .subscribe(result => {
          console.log("Person " + person.personId + " has been updated.");
          this.router.navigate(['/people']);
        }, error => console.log(error));
    } else {
      //ADD NEW MODE
      this.personService.post<Person>(person)
        .subscribe(result => {
          console.log("Person " + person.personId + " has been created.");
          this.router.navigate(['/people']);
        }, error => console.log(error));
    }
  }

}
