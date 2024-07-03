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

var lowStockProducts = Products.AsEnumerable()
                               .SkipWhile(p => p.Stock > 20)
                               .ToList();
lowStockProducts.Dump("Productos Despues de Skippear mientras sean > 20");

//
var startDate = new DateOnly(2024, 7, 1);
var ordersFromJuly = Orders.AsEnumerable()
                           .SkipWhile(o => o.Order_date < startDate)
                           .ToList();
ordersFromJuly.Dump("Órdenes desde el 1 de julio de 2024");
//
var expensiveProducts = Products.AsEnumerable()
                                .SkipWhile(p => p.Price >= 900)
                                .ToList();
expensiveProducts.Dump("Productos");