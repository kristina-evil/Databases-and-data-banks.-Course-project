import {Component, OnInit} from '@angular/core';
import {ActivatedRoute} from '@angular/router';
import {EmployeesDataService} from 'src/app/services/employees.service';

import {Employee} from '../../models/employee.interface';

@Component({
  selector: 'kks-details-page',
  templateUrl: './employee-details-page.component.html',
  styleUrls: ['./employee-details-page.component.scss'],
})
export class EmployeeDetailsPageComponent implements OnInit {
  employee: Employee;

  constructor(
    private route: ActivatedRoute,
    private employeesService: EmployeesDataService
  ) {
  }

  ngOnInit(): void {
    this.getEmployee();
  }

  getEmployee(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.employeesService
      .getEmloyeeById(id)
      .subscribe((employee) => (this.employee = employee));
  }

  update() {
    this.employeesService.updateEmployee(this.employee).subscribe();
  }
}
