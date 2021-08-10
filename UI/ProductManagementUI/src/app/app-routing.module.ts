import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { CompaniesComponent } from './components/companies/companies.component';
import { AddEditCompanyComponent } from './components/add-edit-company/add-edit-company.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'companies', component: CompaniesComponent },
  { path: 'companies/add', component: AddEditCompanyComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
