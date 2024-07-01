<Query Kind="Statements">
  <Connection>
    <ID>c43cc22d-c32e-42de-b1c6-9361887ce4d8</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-BHFJURU\SQLEXPRESS</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <Database>Linqpad_ap2</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
</Query>

//#1
// Saltar los primeros 3 clientes
var skippedClients = Clients.Skip(3);

skippedClients.Dump("Clientes después de saltar los primeros 3");

//#2
// Obtengo los productos ordenados por precio descendente
var expensiveProducts = Products.OrderByDescending(p => p.Price);

var skippedExpensiveProducts = expensiveProducts.Skip(2);

skippedExpensiveProducts.Dump("Productos después de saltar los primeros 2 más caros");

var products = Products.ToList().OrderByDescending(p => p.Price);
products.Dump("Productos");
