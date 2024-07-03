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
            new Student() { StudentID = 1, StudentName = "John" },
            new Student() { StudentID = 2, StudentName = "Moin" },
            new Student() { StudentID = 3, StudentName = "Bill" },
            new Student() { StudentID = 4, StudentName = "Ram" },
            new Student() { StudentID = 5, StudentName = "Ron" }
        };

        var selectResult = from s in studentList
                           select s.StudentName;

        foreach (var name in selectResult)
            Console.WriteLine(name);
    }
}
