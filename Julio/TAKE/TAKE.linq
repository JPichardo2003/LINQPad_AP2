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

////METHOD SYNTAX
var firstFiveUsers = Users.Take(5).ToList();
firstFiveUsers.Dump();

var firstThreeOrders = Orders.Take(3).ToList();
firstThreeOrders.Dump();

var firstFourProducts = Products.Take(4).ToList();
firstFourProducts.Dump();

var firstTwoClients = Clients.Take(2).ToList();
firstTwoClients.Dump();

//QUERY SYNTAX
var _firstFiveUsers = (from u in Users
                      select u).Take(5);
_firstFiveUsers.Dump("Primeros 5 usuarios");

var _firstThreeOrders = (from o in Orders
                        select o).Take(3);
_firstThreeOrders.Dump("Primeras 3 órdenes");

var _firstFourProducts = (from p in Products
                         select p).Take(4);
_firstFourProducts.Dump("Primeros 4 productos");

var _firstTwoClients = (from c in Clients
                       select c).Take(2);
_firstTwoClients.Dump("Primeros 2 clientes");


//Tomar las primeras 3 órdenes realizadas en julio de 2024
//METHOD SYNTAX
var startDate = new DateOnly(2024, 7, 1);
var endDate = startDate.AddMonths(1);

var julyOrders = Orders.Where(o => o.Order_date >= startDate && o.Order_date < endDate)
                       .Take(3)
                       .ToList();
julyOrders.Dump();
Orders.ToList().Dump();

//QUERY SYNTAX
var _startDate = new DateOnly(2024, 7, 1);
var _endDate = _startDate.AddMonths(1);
var _julyOrders = (from o in Orders
                  where o.Order_date >= _startDate && o.Order_date < _endDate
                  select o).Take(3);
_julyOrders.Dump("Primeras 3 órdenes de julio de 2024");

//Tomar los primeros 5 productos con más stock:
//METHOD SYNTAX
var topStockProducts = Products.OrderByDescending(p => p.Stock).Take(5).ToList();
topStockProducts.Dump();
Products.ToList().Dump();

//QUERY SYNTAX
var _topStockProducts = (from p in Products
                        orderby p.Stock descending
                        select p).Take(5);
_topStockProducts.Dump("Primeros 5 productos con más stock");

//Tomar los primeros 4 clientes mas jovenes:
//METHOD SYNTAX
var recentClients = Clients.OrderByDescending(c => c.Birth_date).Take(4).ToList();
recentClients.Dump();
Clients.ToList().Dump();

//QUERY SYNTAX
var _recentClients = (from c in Clients
                     orderby c.Birth_date descending
                     select c).Take(4);
_recentClients.Dump("Primeros 4 clientes más jóvenes");

//Simulando TakeWhile, ya que no es Supported, Take Users While user.Name != Mike Jones
var usersUntilMike = new List<Users>();
foreach (var user in Users)
{
    if (user.Name == "Mike Jones")
        break;
    usersUntilMike.Add(user);
}
usersUntilMike.Dump();


