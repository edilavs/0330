using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
     public class Department
    {
        public Department ()
        {
            this._employees = new Employee[0];
        }
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public int SalaryLimit { get; set; }

        private Employee[] _employees;
        public Employee[] Employees
        {
            get { return _employees; }
        }



        public void AddEmployee(Employee  employee)
        {
            if(EmployeeLimit > _employees.Length)
            {
                Array.Resize(ref _employees, _employees.Length + 1);
                _employees[_employees.Length - 1] = employee;

            }


        }
    }
}
