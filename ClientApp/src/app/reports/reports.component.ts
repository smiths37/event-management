import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

import { Report } from './report';
import { ReportService } from './report.service';
import { ApiResult } from '../base.service';

@Component({
  selector: 'app-reports',
  templateUrl: './reports.component.html',
  styleUrls: ['./reports.component.css']
})

export class ReportsComponent {
  reports: Report[];

  constructor(
    private reportService: ReportService,
    private http: HttpClient,
    @Inject('BASE_URL') private baseUrl: string) {
  }

  ngOnInit() {
    this.loadData();
  }

  loadData() {
    this.reportService.getData<ApiResult<Report>>(0, 9999, "reportName", "asc", null, null)
      .subscribe(result => {
        this.reports = result.data;
      }, error => console.error(error));
  }
}

