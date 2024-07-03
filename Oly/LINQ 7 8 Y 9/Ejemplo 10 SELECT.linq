<Query Kind="Program" />

using System;
using System.Collections.Generic;
using System.Linq;



public class Student
{
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
}
class Program
{
    static void Main()
    {
        IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 18 },
            new Student() { StudentID = 2, StudentName = "Moin", Age = 21 },
            new Student() { StudentID = 3, StudentName = "Bill", Age = 18 },
            new Student() { StudentID = 4, StudentName = "Ram", Age = 20 },
            new Student() { StudentID = 5, StudentName = "Ron", Age = 21 }
        };

        var selectResult = studentList.Select(s => new { Name = s.StudentName, Age = s.Age });

        foreach (var item in selectResult)
            Console.WriteLine($"Student Name: {item.Name}, Age: {item.Age}");
    }
}
