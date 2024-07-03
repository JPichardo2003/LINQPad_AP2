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


//Empty

//Empty Ejemplo 1
var emptyList = Enumerable.Empty<string>();
Console.WriteLine("Count: {0} ", emptyList.Count());
Console.WriteLine("Type: {0} ", emptyList.GetType().Name );


//Empty Ejemplo 2 

var emptyProducts = Enumerable.Empty<Products>();
Console.WriteLine("Count: {0}", emptyProducts.Count());
Console.WriteLine("Type: {0}", emptyProducts.GetType().Name);


//Range

//Range Ejemplo 1

 var secuencialNumber = Enumerable.Range(100, 10);
    Console.WriteLine("Total Count: {0}", secuencialNumber.Count());

    for (int i = 0; i < secuencialNumber.Count(); i++)
        Console.WriteLine("Valor de indice {0}: {1}", i, secuencialNumber.ElementAt(i));
		
// Range Ejemplo 2
var newClientIds = Enumerable.Range(1, 10);
    Console.WriteLine("Nuevos IDs de Clientes:");

    foreach (var id in newClientIds)
    {
        Console.WriteLine(id);
    }


//Repeat

//Repeat Ejemplo 1 

 var repeatedNumero = Enumerable.Repeat("10", 5);
    Console.WriteLine("Repetir Numero:");

    foreach (var numero in repeatedNumero)
    {
        Console.WriteLine(numero);
    }

//Repeat Ejemplo 2
  var repeatedName = Enumerable.Repeat("Yokaira.", 5);
    Console.WriteLine("Repetir Nombre:");

    foreach (var nombre in repeatedName)
    {
        Console.WriteLine(nombre);
    }
