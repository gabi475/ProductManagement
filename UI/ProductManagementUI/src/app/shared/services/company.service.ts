import { Injectable } from '@angular/core';
import { HttpClient, HttpErrorResponse } from '@angular/common/http';
import { Company } from '../models/company';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class CompanyService {
  constructor(private http: HttpClient) {}

  getCompanies() {
    return this.http.get<Company[]>('http://localhost:4000/api/company');
  }

  addCompany(company: Company): Observable<Company> {
    return this.http.post<Company>('http://localhost:4000/api/company', {
      name: company.name,
      ceo: company.CEO,
      location: company.location,
      revenue: company.revenue,
      employeesNumber: company.employeesNumber,
    });
  }
}
