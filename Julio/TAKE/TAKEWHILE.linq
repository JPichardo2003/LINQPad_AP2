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

//Usuarios hasta que encuentre Mike Jones
var usersUntilMike = Users.AsEnumerable()
                          .TakeWhile(u => u.Name != "Mike Jones")
                          .ToList();
usersUntilMike.Dump("Usuarios hasta 'Mike Jones'");
Users.Dump();
//
var affordableProducts = Products.AsEnumerable()
                                 .TakeWhile(p => p.Price >= 500)
                                 .ToList();
affordableProducts.Dump("Productos con precio mayor o igual a 500");
Products.Dump();
//
var startDate = new DateOnly(2024, 7, 1);
var ordersBeforeJuly = Orders.AsEnumerable()
                             .TakeWhile(o => o.Order_date < startDate)
                             .ToList();
ordersBeforeJuly.Dump("Órdenes antes del 1 de julio de 2024");
Orders.Dump();
//
var availableProducts = Products.AsEnumerable()
                                .TakeWhile(p => p.Stock > 20)
                                .ToList();
availableProducts.Dump("Productos con stock mayor a 20");
