<Query Kind="Program" />

using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        IList<IList<int>> numberList = new List<IList<int>>() {
            new List<int>() { 1, 2, 3 },
            new List<int>() { 4, 5, 6 },
            new List<int>() { 7, 8, 9 }
        };

        var selectManyResult = numberList.SelectMany(numbers => numbers);

        foreach (var num in selectManyResult)
            Console.WriteLine(num);
    }
}
