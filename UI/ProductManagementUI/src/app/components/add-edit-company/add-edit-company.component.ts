import { Component, OnInit } from '@angular/core';
import { Company } from '../../shared/models/company';
import { CompanyService } from '../../shared/services/company.service';

@Component({
  selector: 'app-add-edit-company',
  templateUrl: './add-edit-company.component.html',
  styleUrls: ['./add-edit-company.component.css'],
})
export class AddEditCompanyComponent implements OnInit {
  company: Company = new Company();

  constructor(private companyService: CompanyService) {}

  ngOnInit(): void {}
  onSubmit() {
    console.log(this.company);

    this.companyService.addCompany(this.company).subscribe((company) => {
      console.log(company);
      this.company = new Company();
    });
  }
}
