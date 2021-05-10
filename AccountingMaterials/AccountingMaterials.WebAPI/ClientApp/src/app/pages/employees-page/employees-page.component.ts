import {Component, OnInit} from '@angular/core';
import {EmployeesDataService} from 'src/app/services/employees.service';

import {Employee} from '../../models/employee.interface';

@Component({
  selector: 'app-home-page',
  templateUrl: './employees-page.component.html',
  styleUrls: ['./employees-page.component.scss'],
})
export class EmployeesPageComponent implements OnInit {
  employees: Employee[];

  constructor(private employeesService: EmployeesDataService) {
  }

  ngOnInit(): void {
    this.getEmployees();
  }

  getEmployees(): void {
    this.employeesService
      .getEmployeesList()
      .subscribe((employees) => (this.employees = employees));
  }
}
