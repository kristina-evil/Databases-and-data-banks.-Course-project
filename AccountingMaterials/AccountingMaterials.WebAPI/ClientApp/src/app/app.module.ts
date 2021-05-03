import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomePageComponent } from './pages/home-page/home-page.component';
import { FooterComponent } from './layout/footer/footer.component';
import { NavbarComponent } from './layout/navbar/navbar.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MaterialModule } from 'src/material.module';
import { AboutPageComponent } from './pages/about-page/about-page.component';
import { DetailsPageComponent } from './pages/details-page/details-page.component';
import { FormsModule } from '@angular/forms';
import { EmployeesDataService } from './services/employees.service';
import { HttpClientModule } from '@angular/common/http';
import { MaterialsPageComponent } from './pages/materials-page/materials-page.component';

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    FooterComponent,
    NavbarComponent,
    AboutPageComponent,
    DetailsPageComponent,
    MaterialsPageComponent,
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
export class AppModule {}
