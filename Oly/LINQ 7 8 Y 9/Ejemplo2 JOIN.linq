<Query Kind="Program" />

using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{ 
    public int StudentID { get; set; }
    public string StudentName { get; set; }
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
            new Student() { StudentID = 1, StudentName = "John", StandardID =1 },
            new Student() { StudentID = 2, StudentName = "Moin", StandardID =1 },
            new Student() { StudentID = 3, StudentName = "Bill", StandardID =2 },
            new Student() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
            new Student() { StudentID = 5, StudentName = "Ron"  }
        };

        IList<Standard> standardList = new List<Standard>() { 
            new Standard(){ StandardID = 1, StandardName="Standard 1"},
            new Standard(){ StandardID = 2, StandardName="Standard 2"},
            new Standard(){ StandardID = 3, StandardName="Standard 3"}
        };

        var innerJoinQuery = from student in studentList
                             join standard in standardList
                             on student.StandardID equals standard.StandardID
                             select new 
                             {
                                 StudentName = student.StudentName,
                                 StandardName = standard.StandardName
                             };

        foreach (var obj in innerJoinQuery)
            Console.WriteLine($"{obj.StudentName} - {obj.StandardName}");
    }
}
