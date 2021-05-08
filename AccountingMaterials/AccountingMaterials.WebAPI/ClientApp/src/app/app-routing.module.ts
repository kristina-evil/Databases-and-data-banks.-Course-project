import {NgModule} from '@angular/core';
import {RouterModule, Routes} from '@angular/router';
import {AboutPageComponent} from './pages/about-page/about-page.component';
import {EmployeesPageComponent} from './pages/employees-page/employees-page.component';
import {EmployeeDetailsPageComponent} from './pages/employee-details-page/employee-details-page.component';
import {MaterialsPageComponent} from './pages/materials-page/materials-page.component';
import {MaterialDetailsComponent} from './pages/material-details-page/material-details.component';

const routes: Routes = [
  {path: '', redirectTo: 'employees', pathMatch: 'full'},
  {path: 'employees', component: EmployeesPageComponent},
  {path: 'materials', component: MaterialsPageComponent},
  {path: 'about', component: AboutPageComponent},
  {path: 'contacts', redirectTo: 'about'},
  {path: 'employee-details/:id', component: EmployeeDetailsPageComponent},
  {path: 'material-details/:id', component: MaterialDetailsComponent},
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {
}
