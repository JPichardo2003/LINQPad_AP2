using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }

    static void Main()
    {
        IList<Student> studentList = new List<Student>
        {
            new Student { StudentID = 1, StudentName = "John", Age = 13 },
            new Student { StudentID = 2, StudentName = "Moin", Age = 21 },
            new Student { StudentID = 3, StudentName = "Bill", Age = 18 },
            new Student { StudentID = 4, StudentName = "Ram", Age = 20 },
            new Student { StudentID = 5, StudentName = "Ron", Age = 15 }
        };

        // 1: Calcular el promedio de edad
        var avgAge = studentList.Average(s => s.Age);
        Console.WriteLine("Promedio de edad: {0}", avgAge);

        // 2: Contar el número de estudiantes mayores o iguales a 18 años
        var totalStudents = studentList.Count(st => st.Age >= 18);
        Console.WriteLine("Mayores de edad (Age >= 18): {0}", totalStudents);

        // 3: Obtener la lista de nombres de los estudiantes menores de 18 años
        var youngStudents = studentList.Where(s => s.Age < 18).Select(s => s.StudentName).ToList();
        Console.WriteLine("Estudiantes menores de 18: {0}", string.Join(", ", youngStudents));
    }
}
