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

//DefaultIfEmpty

    
//Ejemplo 1
var clientEmails = Clients.Select(c => c.Email).ToList();

var clientEmailsWithDefault = clientEmails.DefaultIfEmpty("No hay Clientes disponibles");

Console.WriteLine("Count: {0}", clientEmailsWithDefault.Count());
Console.WriteLine("Value: {0}", clientEmailsWithDefault.ElementAt(0));

	
//Ejemplo 2
var userNames = Users.Select(u => u.Name).ToList();
var clientNames = Clients.Select(c => c.Name).ToList();
var userNamesWithDefault = userNames.DefaultIfEmpty("No hay usuarios disponibles");
var clientNamesWithDefault = clientNames.DefaultIfEmpty("No hay clientes disponibles");


Console.WriteLine("Count: {0}", userNamesWithDefault.Count());
Console.WriteLine("Value: {0}", userNamesWithDefault.ElementAt(0));

Console.WriteLine("Count: {0}", clientNamesWithDefault.Count());
Console.WriteLine("Value: {0}", clientNamesWithDefault.ElementAt(0));
	
//Ejemplo 3
var userLogs = UserLogs.Select(ul => ul.Action).ToList();

var userLogsWithDefault = userLogs.DefaultIfEmpty("No hay acciones disponibles");

Console.WriteLine("Count: {0}", userLogsWithDefault.Count());
Console.WriteLine("Value: {0}", userLogsWithDefault.ElementAt(0));
	
	