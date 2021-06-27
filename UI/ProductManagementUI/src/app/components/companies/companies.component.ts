import { Component, OnInit } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';

@Component({
  selector: 'app-companies',
  templateUrl: './companies.component.html',
  styleUrls: ['./companies.component.css'],
})
export class CompaniesComponent implements OnInit {
  companies: any[] = [];
  products: any[] = [];

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.http
      .get<any>('http://localhost:4000/api/company')
      .subscribe((companies) => {
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

  onAddCompanyClick() {
    this.http
      .post<any>('http://localhost:4000/api/company', { name: 'Dummy company' })
      .subscribe((company) => {
        console.log(company);
      });
  }
}
