<Query Kind="Statements" />

IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four" };
IList<string> strList2 = new List<string>() { "Three", "Four", "Five", "Six" };

var innerJoin = strList1.Join(
    strList2,
    str1 => str1,
    str2 => str2,
    (str1, str2) => str2
);

foreach (var str in innerJoin)
    Console.WriteLine(str);