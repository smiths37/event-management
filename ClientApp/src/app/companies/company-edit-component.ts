import { Component, Inject, ViewChild, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators, AsyncValidatorFn, AbstractControl } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';

import { Company } from './company';
import { CompanyService } from './company.service';
import { CompanyTypeService } from '../maintenance/company-types/company-type.service';
import { SourceTypeService } from '../maintenance/source-types/source-type-service';
import { CompanyType } from '../maintenance/company-types/company-type';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { ApiResult } from '../base.service';
import { BaseFormComponent } from '../base.form.component'
import { Source } from '../maintenance/source-types/source-type';

@Component({
  selector: 'app-company-edit',
  templateUrl: './company-edit.component.html',
  styleUrls: ['./company-edit.component.css', '../../global.css']
})

export class CompanyEditComponent extends BaseFormComponent implements OnInit {
  title: string;
  form: FormGroup;
  company: Company;
  companyId?: number;

  companyTypes: CompanyType[];
  sources: Source[];

  constructor(
    private activatedRoute: ActivatedRoute,
    private router: Router,
    private companyService: CompanyService,
    private companyTypeService: CompanyTypeService,
    private sourceTypeService: SourceTypeService,
    @Inject('BASE_URL') private baseUrl: string
  ) {
    super();
  }

  ngOnInit() {
    this.form = new FormGroup({
      companyName: new FormControl('', Validators.required),
      alphaIndexName: new FormControl('', Validators.required),
      companyType: new FormControl('', Validators.required),
      source: new FormControl('')
    }, null, this.isDuplicate());
    this.loadData();
  }

  loadData() {
    //load company types, source types
    this.loadCompanyTypes();
    this.loadSources();
   

    this.companyId = +this.activatedRoute.snapshot.paramMap.get('companyId');

    if (this.companyId) {
      //EDIT MODE
      var url = this.baseUrl + "api/companies/" + this.companyId;
      this.companyService.get<Company>(this.companyId)
        .subscribe(result => {
        this.company = result;
        this.title = "Edit " + this.company.companyName;

          this.form.patchValue(this.company);

          //the above was not setting the source field - manually do this instead...
          this.form.get('source').setValue(this.company.sourceId);

      }, error => console.error(error));
    } else {
      //ADD NEW MODE
      this.title = "Add a new Company";
    }
  }

  loadCompanyTypes() {
    this.companyTypeService.getData<ApiResult<CompanyType>>(0, 9999, "companyTypeDesc", "asc", null, null)
      .subscribe(result => {
        this.companyTypes = result.data;
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

  onSubmit() {
    this.companyId = +this.activatedRoute.snapshot.paramMap.get('companyId');

    var company = (this.companyId) ? this.company : <Company>{};

    company.companyName = this.form.get("companyName").value;
    company.companyType = +this.form.get("companyType").value;
    company.alphaindexName = this.form.get("alphaIndexName").value;
    company.sourceId = +this.form.get("source").value;
    console.log("Soruce field " + this.form.get("source").value);

    if (this.companyId) {
      //EDIT MODE
      this.companyService.put<Company>(company)
        .subscribe(result => {
        console.log("Company " + company.companyId + " has been updated.");
        this.router.navigate(['/companies']);
      }, error => console.log(error));
    } else {
      //ADD NEW MODE
      this.companyService.post<Company>(company)
        .subscribe(result => {
        console.log("Company " + company.companyId + " has been created.");
        this.router.navigate(['/companies']);
      }, error => console.log(error));
    }
  }

  isDuplicate() {
    return (control: AbstractControl): Observable<{ [key: string]: any } | null> => {
      var company = <Company>{};
      company.companyId = (this.companyId) ? this.companyId : 0;
      company.companyName = this.form.get("companyName").value;

      return this.companyService.isDuplicate(company)
        .pipe(map(result => {
          return (result ? { isDuplicate: true } : null);
        }));
    }
  }

  onDelete() {
    var company = (this.companyId) ? this.company : <Company>{};

    this.companyService.delete<Company>(company.companyId)
      .subscribe(result => {
        console.log("Company " + company.companyId + " has been deleted.");
        this.router.navigate(['/companies']);
      }, error => console.error(error));
  }
}

