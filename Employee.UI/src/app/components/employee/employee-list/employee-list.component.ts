import { Employee } from './../../../models/employee.model';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit{

  employees: Employee[] = [
    {
      id: '',
      name: '',
      email: '',
      phone: 0,
      salary: 0,
      department: ''
    }
  ];

  constructor() {}

  ngOnInit(): void {
    this.employees;
  }
}
