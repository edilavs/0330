using System;
using ClassLibrary;
using static ClassLibrary.Department;


namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Isci adini daxil et:");
            string name = Console.ReadLine();
            Console.WriteLine("1.Isci soyadini daxil et:");
            string surname = Console.ReadLine();
            Console.WriteLine("1.Iscinin ayliq maasini daxil et:");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.Isci adini daxil et:");
            string secondEmployeesName = Console.ReadLine();
            Console.WriteLine("2.Isci soyadini daxil et:");
            string secondEmployeeSurname = Console.ReadLine();
            Console.WriteLine("2.Iscinin ayliq maasini daxil et:");
            int secondEmployeesSalary = Convert.ToInt32(Console.ReadLine());

            Employee employee1 = new Employee();
            employee1.Name = name;
            employee1.Surname = surname;
            employee1.Salary = secondEmployeesSalary;
            Console.WriteLine($"Iscinin Adi:{employee1.Name}\nIscinin Soyadi:{employee1.Surname }\nAyliq maasi:{employee1.Salary}AZN\n");

            Employee employee2 = new Employee();
            employee2.Name = secondEmployeesName;
            employee2.Surname = secondEmployeeSurname;
            employee2.Salary = salary;
            Console.WriteLine($"Iscinin Adi:{employee2.Name}\nIscinin Soyadi:{employee2.Surname }\nAyliq maasi:{employee2.Salary}AZN\n");

            Console.WriteLine("Departmentin adini daxil et:");
            string departmentName = Console.ReadLine();
            Console.WriteLine("Isci sayi ucun limit daxil et:");
            int employeeLimit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ayliq maas ucun limit daxil et:");
            int salaryLimit = Convert.ToInt32(Console.ReadLine());

            Department department = new Department();
            department.SalaryLimit = salaryLimit;
            department.Name = departmentName;
            department.EmployeeLimit = employeeLimit;

            department.AddEmployee(employee1);
            department.AddEmployee(employee2);

            foreach (var item in department.Employees )
            {
                Console.WriteLine($"Elave olunan iscilerin adi:{item.Name}");
            }
        }
    }
}
