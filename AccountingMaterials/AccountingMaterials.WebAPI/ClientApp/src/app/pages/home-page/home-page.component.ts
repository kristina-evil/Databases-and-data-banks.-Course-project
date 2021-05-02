import { Component, OnInit } from '@angular/core';
import { EmployeesDataService } from 'src/app/services/employees.service';

import { Employee } from '../../models/employee.interface';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss'],
})
export class HomePageComponent implements OnInit {
  employees: Employee[];

  constructor(private employeesService: EmployeesDataService) {}

  ngOnInit(): void {
    this.getEmployees();
  }

  getEmployees(): void {
    this.employeesService
      .getEmployeesList()
      .subscribe((employees) => (this.employees = employees));
  }
}
