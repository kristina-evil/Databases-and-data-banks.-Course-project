import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';

import { Employee } from '../../models/employee.interface';
import { EmployeeService } from '../../employee.service';

@Component({
  selector: 'kks-details-page',
  templateUrl: './details-page.component.html',
  styleUrls: ['./details-page.component.scss'],
})
export class DetailsPageComponent implements OnInit {
  employee: Employee;

  constructor(
    private route: ActivatedRoute,
    private employeeService: EmployeeService
  ) {}

  ngOnInit(): void {
    this.getEmployee();
  }

  getEmployee(): void {
    const id = Number(this.route.snapshot.paramMap.get('id'));
    this.employeeService
      .getEmployee(id)
      .subscribe((employee) => (this.employee = employee));
  }
}
