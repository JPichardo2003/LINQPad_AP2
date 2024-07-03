<Query Kind="Program" />

using System;
using System.Collections.Generic;
using System.Linq;

public class Employee
{ 
    public int EmployeeID { get; set; }
    public string EmployeeName { get; set; }
    public int DepartmentID { get; set; }
}

public class Department
{ 
    public int DepartmentID { get; set; }
    public string DepartmentName { get; set; }
}

class Program
{
    static void Main()
    {
        IList<Employee> employeeList = new List<Employee>() {
            new Employee() { EmployeeID = 1, EmployeeName = "Alice", DepartmentID = 3 },
            new Employee() { EmployeeID = 2, EmployeeName = "Bob", DepartmentID = 1 },
            new Employee() { EmployeeID = 3, EmployeeName = "Charlie", DepartmentID = 2 },
            new Employee() { EmployeeID = 4, EmployeeName = "David", DepartmentID = 3 }
        };

        IList<Department> departmentList = new List<Department>() { 
            new Department() { DepartmentID = 1, DepartmentName = "HR" },
            new Department() { DepartmentID = 2, DepartmentName = "IT" },
            new Department() { DepartmentID = 3, DepartmentName = "Finance" }
        };

        var innerJoinQuery = from emp in employeeList
                             join dept in departmentList
                             on emp.DepartmentID equals dept.DepartmentID
                             select new 
                             {
                                 EmployeeName = emp.EmployeeName,
                                 DepartmentName = dept.DepartmentName
                             };

        foreach (var obj in innerJoinQuery)
            Console.WriteLine($"{obj.EmployeeName} - {obj.DepartmentName}");
    }
}
