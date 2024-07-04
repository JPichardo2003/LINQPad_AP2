using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        IList<int> intList = new List<int>() {10, 20, 30, 40, 50, 60, 70, 80, 90};

        var avg = intList.Average();

        Console.WriteLine("El Promedio es: {0}", avg);
    }
}
