import { EmployeesService } from 'src/app/services/employees.service';
import { Employee } from './../../../models/employee.model';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit{

  employees: Employee[] = [];

  constructor(private employeesService: EmployeesService) {}

  ngOnInit(): void {
    this.employeesService.getAllEmployees().subscribe({
      next: (employee) => {
        this.employees = employee;
      },
      error: (response) => {
        console.log(response);
      }
    });
  }
}
