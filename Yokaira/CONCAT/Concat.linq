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

//CONCAT

	
//Ejemplo 1

var userNames = Users.Select(u => u.Name).ToList(); 
var productNames = Products.Select(p => p.Description).ToList();

var concatedNames = userNames.Concat(productNames);

concatedNames.Dump("Lista concatenada (Nombres de usuarios y descripciones de productos)"); 

//Ejemplo 2

var clientsNames = Clients.Select(c => c.Name).ToList();
var userPassword = Users.Select(u => u.Password).ToList();

var concatedList = clientsNames.Concat(userPassword);

concatedList.Dump("Lista concatenada (Nombres de clientes y Contraseñas de Usuarios)");


//Ejemplo 3

var userName = Users.Select(u => u.Name).ToList(); 
var userEmails = Users.Select(u => u.Email).ToList();

var concatenatedList = userName.Concat(userEmails);
var duplicates = concatenatedList.GroupBy(x => x)
                                     .Where(g => g.Count() > 1)
                                     .Select(y => y.Key);
									 
duplicates.Dump("Duplicados (Nombres y correos electrónicos)");


var uniqueList = concatenatedList.Distinct();

uniqueList.Dump("Lista concatenada sin duplicados (Nombres y correos electrónicos)");