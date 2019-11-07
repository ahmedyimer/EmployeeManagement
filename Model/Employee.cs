﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }

    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        void Save(Employee employee);
    }

    public class EmployeeRepository : IEmployeeRepository
    {
        public Employee GetEmployee(int id)
        {
            // Logic to retrieve employee details
            return new Employee();
        }

        public void Save(Employee employee)
        {
            // Logic to save employee details
        }
    }

}
