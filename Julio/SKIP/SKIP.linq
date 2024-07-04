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

// Saltar los primeros 3 clientes
//METHOD SYNTAX
var skippedClients = Clients.Skip(3);
skippedClients.Dump("Clientes después de saltar los primeros 3");
Clients.ToList().Dump();

//QUERY SYNTAX
var _skippedClients = from c in Clients 
                     select c;
_skippedClients = _skippedClients.Skip(3);
_skippedClients.Dump("Clientes después de saltar los primeros 3");

// Obtengo los productos ordenados por precio descendente
//METHOD SYNTAX
var expensiveProducts = Products.OrderByDescending(p => p.Price);
var skippedExpensiveProducts = expensiveProducts.Skip(2);
skippedExpensiveProducts.Dump("Productos después de saltar los primeros 2 más caros");

var products = Products.ToList().OrderByDescending(p => p.Price);
products.Dump("Productos");

//QUERY SYNTAX
var _expensiveProducts = from p in Products
                        orderby p.Price descending
                        select p;
var _skippedExpensiveProducts = _expensiveProducts.Skip(2);
_skippedExpensiveProducts.Dump("Productos después de saltar los primeros 2 más caros");


//Saltar las primeras 2 órdenes y tomar las siguientes 3
//METHOD SYNTAX
var skipFirstTwoOrders = Orders.Skip(2).Take(3).ToList();
skipFirstTwoOrders.Dump();

Orders.ToList().Dump();

//QUERY SYNTAX
var _skipFirstTwoOrders = (from o in Orders
                          select o).Skip(2).Take(3);
_skipFirstTwoOrders.Dump("Órdenes después de saltar las primeras 2 y tomar las siguientes 3");

//Saltar los primeros 5 productos con menor stock y tomar los siguientes 5
//METHOD SYNTAX
var midStockProducts = Products.OrderBy(p => p.Stock).Skip(5).Take(5).ToList();
midStockProducts.Dump();

Products.ToList().Dump("Productos");

//QUERY SYNTAX
var _midStockProducts = (from p in Products
                        orderby p.Stock
                        select p).Skip(5).Take(5);
_midStockProducts.Dump("Productos después de saltar los primeros 5 con menor stock y tomar los siguientes 5");