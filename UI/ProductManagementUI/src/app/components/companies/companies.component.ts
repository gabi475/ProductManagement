import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';

import { CompanyService } from '../../shared/services/company.service';

@Component({
  selector: 'app-companies',
  templateUrl: './companies.component.html',
  styleUrls: ['./companies.component.css'],
})
export class CompaniesComponent implements OnInit {
  companies: any[] = [];
  products: any[] = [];

  constructor(private companyService: CompanyService) {}

  ngOnInit(): void {
    this.companyService.getCompanies().subscribe((companies) => {
      this.companies = companies;
    });
    
  }

  public onCompanyChange(e) {
    console.log(e.value);
    let company = this.companies.find((o) => o.id === e.value);
    if (company !== undefined) {
      this.products = company.products;
    }
  }
}
