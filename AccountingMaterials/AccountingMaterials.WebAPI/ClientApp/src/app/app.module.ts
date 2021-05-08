import {NgModule} from '@angular/core';
import {BrowserModule} from '@angular/platform-browser';

import {AppRoutingModule} from './app-routing.module';
import {AppComponent} from './app.component';
import {EmployeesPageComponent} from './pages/employees-page/employees-page.component';
import {FooterComponent} from './layout/footer/footer.component';
import {NavbarComponent} from './layout/navbar/navbar.component';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import {MaterialModule} from 'src/material.module';
import {AboutPageComponent} from './pages/about-page/about-page.component';
import {EmployeeDetailsPageComponent} from './pages/employee-details-page/employee-details-page.component';
import {FormsModule} from '@angular/forms';
import {EmployeesDataService} from './services/employees.service';
import {HttpClientModule} from '@angular/common/http';
import {MaterialsPageComponent} from './pages/materials-page/materials-page.component';
import {MaterialDetailsComponent} from './pages/material-details-page/material-details.component';

@NgModule({
  declarations: [
    AppComponent,
    EmployeesPageComponent,
    FooterComponent,
    NavbarComponent,
    AboutPageComponent,
    EmployeeDetailsPageComponent,
    MaterialsPageComponent,
    MaterialDetailsComponent,
  ],
  imports: [
    FormsModule,
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MaterialModule,
    HttpClientModule,
  ],
  providers: [EmployeesDataService],
  bootstrap: [AppComponent],
})
export class AppModule {
}
