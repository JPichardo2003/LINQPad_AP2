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
var firstFiveUsers = Users.Take(5).ToList();
firstFiveUsers.Dump();
//#2
var firstThreeOrders = Orders.Take(3).ToList();
firstThreeOrders.Dump();
//#3
var firstFourProducts = Products.Take(4).ToList();
firstFourProducts.Dump();
//#4
var firstTwoClients = Clients.Take(2).ToList();
firstTwoClients.Dump();

//Tomar las primeras 3 órdenes realizadas en julio de 2024
var startDate = new DateOnly(2024, 7, 1);
var endDate = startDate.AddMonths(1);

var julyOrders = Orders.Where(o => o.Order_date >= startDate && o.Order_date < endDate)
                       .Take(3)
                       .ToList();
julyOrders.Dump();
Orders.ToList().Dump();

//Tomar los primeros 5 productos con más stock:
var topStockProducts = Products.OrderByDescending(p => p.Stock).Take(5).ToList();
topStockProducts.Dump();
Products.ToList().Dump();

//Tomar los primeros 4 clientes mas jovenes:
var recentClients = Clients.OrderByDescending(c => c.Birth_date).Take(4).ToList();
recentClients.Dump();
Clients.ToList().Dump();

//Simulando TakeWhile, ya que no es Supported, Take Users While user.Name != Mike Jones
var usersUntilMike = new List<Users>();
foreach (var user in Users)
{
    if (user.Name == "Mike Jones")
        break;
    usersUntilMike.Add(user);
}
usersUntilMike.Dump();


