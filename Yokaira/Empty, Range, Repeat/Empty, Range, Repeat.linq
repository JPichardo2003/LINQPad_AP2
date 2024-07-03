<Query Kind="Statements">
  <Connection>
    <ID>229d8b90-4257-4c07-85ae-bd638c79936f</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-DLJFML1\SQLEXPRESS</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <Database>Linqpad_ap2</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
</Query>

//Empty, Range, Repeat.

//Empty

//Ejemplo 1 Empty
var emptyList = Enumerable.Empty<string>();
Console.WriteLine("Count: {0} ", emptyList.Count());
Console.WriteLine("Type: {0} ", emptyList.GetType().Name );


//Ejemplo 2 Empty


















//Ejemplo: Enumerable.Empty()
var emptyCollection1 = Enumerable.Empty<string>();
//var emptyCollection2 = Enumerable.Empty<Student>();

Console.WriteLine("Count: {0} ", emptyCollection1.Count());
Console.WriteLine("Type: {0} ", emptyCollection1.GetType().Name );

Console.WriteLine("Count: {0} ",emptyCollection2.Count());
Console.WriteLine("Type: {0} ", emptyCollection2.GetType().Name );

var userLogs = UserLogs.Select(ul => ul.Action).ToList();

var userLogsWithDefault = userLogs.DefaultIfEmpty("No hay acciones disponibles");

Console.WriteLine("Count: {0}", userLogsWithDefault.Count());
Console.WriteLine("Value: {0}", userLogsWithDefault.ElementAt(0));

//ABRAHAM
var emptyList = Enumerable.Empty<string>();
Console.WriteLine("Count: {0} ", emptyList.Count());
Console.WriteLine("Type: {0} ", emptyList.GetType().Name );

	IList<string> emptyList = new List<string>();
	Console.WriteLine("Ultimo elemento de la lista vacia: {0}", emptyList.LastOrDefault());
//


var intCollection = Enumerable.Range(10, 10);
Console.WriteLine("Total Count: {0} ", intCollection.Count());

for(int i = 0; i < intCollection.Count(); i++)
    Console.WriteLine("Value at index {0} : {1}", i, intCollection.ElementAt(i));
	
	var intCollection = Enumerable.Repeat<int>(10, 10);
Console.WriteLine("Total Count: {0} ", intCollection.Count());

for(int i = 0; i < intCollection.Count(); i++)
    Console.WriteLine("Value at index {0} : {1}", i, intCollection.ElementAt(i));