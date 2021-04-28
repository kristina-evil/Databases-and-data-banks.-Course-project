import { Injectable } from '@angular/core';

import { Employee } from './models/employee.interface';
import { EMPLOYEES } from './employees';
import { Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root',
})
export class EmployeeService {
  constructor() {}

  getEmployees(): Observable<Employee[]> {
    const employees = of(EMPLOYEES);
    return employees;
  }

  getEmployee(id: number): Observable<Employee> {
    const employee = EMPLOYEES.find((emp) => emp.id === id) as Employee;
    return of(employee);
  }
}
