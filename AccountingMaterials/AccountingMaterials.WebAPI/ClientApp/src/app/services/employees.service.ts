import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Employee } from '../models/employee.interface';
import { RequestBuilder } from './request-builder';

const apiController = 'Employees';

@Injectable({
    providedIn: 'root'
})
export class EmployeesDataService {

    constructor(private readonly builder: RequestBuilder) { }

    public getEmployeesList(): Observable<Employee[]> {
        return this.builder.useApiUrl(`${apiController}/`).get<Employee[]>();
    }

    public getEmloyeeById(id: number): Observable<Employee> {
        return this.builder.useApiUrl(`${apiController}/${id}/`).get<Employee>();
    }

    public updateEmployee(employee: Employee) {
        return this.builder.useApiUrl(apiController).put(employee);
    }
}