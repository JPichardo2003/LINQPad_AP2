<Query Kind="Program" />

using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{ 
    public int StudentID { get; set; }
    public string StudentName { get; set; }
    public int Age { get; set; }
    public int StandardID { get; set; }
}

public class Standard
{ 
    public int StandardID { get; set; }
    public string StandardName { get; set; }
}

class Program
{
    static void Main()
    {
        IList<Student> studentList = new List<Student>() {
            new Student() { StudentID = 1, StudentName = "John", Age = 13, StandardID = 1 },
            new Student() { StudentID = 2, StudentName = "Moin", Age = 21, StandardID = 1 },
            new Student() { StudentID = 3, StudentName = "Bill", Age = 18, StandardID = 2 },
            new Student() { StudentID = 4, StudentName = "Ram", Age = 20, StandardID = 2 },
            new Student() { StudentID = 5, StudentName = "Ron", Age = 15, StandardID = 3 }
        };

        IList<Standard> standardList = new List<Standard>() { 
            new Standard() { StandardID = 1, StandardName = "Standard 1" },
            new Standard() { StandardID = 2, StandardName = "Standard 2" },
            new Standard() { StandardID = 3, StandardName = "Standard 3" }
        };

        var groupJoinQuery = from std in standardList
                             join s in studentList
                             on std.StandardID equals s.StandardID
                             into studentGroup
                             select new 
                             {
                                 StandardName = std.StandardName,
                                 Students = studentGroup
                             };

        foreach (var standard in groupJoinQuery)
        {
            Console.WriteLine(standard.StandardName);
            foreach (var student in standard.Students)
            {
                Console.WriteLine($"  {student.StudentName}");
            }
        }
    }
}
