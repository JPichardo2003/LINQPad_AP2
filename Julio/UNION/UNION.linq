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

//UNION

//METHOD SYNTAX
var userNames = Users.Select(u => u.Name);
var clientNames = Clients.Select(c => c.Name);

var combinedNames = userNames.Union(clientNames);
combinedNames.Dump("Nombres combinados (Usuarios y Clientes)");

//QUERY SYNTAX
var _userNames = from u in Users
                select u.Name;
var _clientNames = from c in Clients
                  select c.Name;
var _combinedNames = _userNames.Union(_clientNames);
_combinedNames.Dump("Nombres combinados (Usuarios y Clientes)");

//METHOD SYNTAX
var userEmails = Users.Select(u => u.Email);
var clientEmails = Clients.Select(c => c.Email);

var combinedEmails = userEmails.Union(clientEmails);
combinedEmails.Dump("Emails combinados (Usuarios y Clientes)");

//QUERY SYNTAX
var _userEmails = from u in Users
                 select u.Email;
var _clientEmails = from c in Clients
                   select c.Email;
var _combinedEmails = _userEmails.Union(_clientEmails);
_combinedEmails.Dump("Emails combinados (Usuarios y Clientes)");

// Obtener los IDs de los usuarios y Clientes que han hecho pedidos
//METHOD SYNTAX
var userOrderIds = Orders.Select(o => o.User_id);
var clientOrderIds = Orders.Select(o => o.Client_id);

// Combinar ambas listas y eliminar duplicados
var combinedOrderIds = userOrderIds.Union(clientOrderIds);
combinedOrderIds.Dump("IDs combinados (Usuarios y Clientes que han hecho pedidos)");

//QUERY SYNTAX
var _userOrderIds = from o in Orders
                   select o.User_id;
var _clientOrderIds = from o in Orders
                     select o.Client_id;
var _combinedOrderIds = _userOrderIds.Union(_clientOrderIds);
_combinedOrderIds.Dump("IDs combinados (Usuarios y Clientes que han hecho pedidos)");

//Unir órdenes hechas por dos usuarios específicos:
//METHOD SYNTAX
var user1Orders = Orders.Where(o => o.User_id == 1);
var user2Orders = Orders.Where(o => o.User_id == 2);

var combinedOrders = user1Orders.Union(user2Orders).ToList();
combinedOrders.Dump();

//QUERY SYNTAX
var _user1Orders = from o in Orders
                  where o.User_id == 1
                  select o;
var _user2Orders = from o in Orders
                  where o.User_id == 2
                  select o;
var _combinedOrders = _user1Orders.Union(_user2Orders);
_combinedOrders.Dump("Órdenes hechas por dos usuarios específicos");