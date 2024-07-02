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

//#1

var userNames = Users.Select(u => u.Name);

var clientNames = Clients.Select(c => c.Name);

var combinedNames = userNames.Union(clientNames);

combinedNames.Dump("Nombres combinados (Usuarios y Clientes)");

//#2

var userEmails = Users.Select(u => u.Email);

var clientEmails = Clients.Select(c => c.Email);

var combinedEmails = userEmails.Union(clientEmails);

combinedEmails.Dump("Emails combinados (Usuarios y Clientes)");

//#3
// Obtener los IDs de los usuarios y Clientes que han hecho pedidos
var userOrderIds = Orders.Select(o => o.User_id);

var clientOrderIds = Orders.Select(o => o.Client_id);

// Combinar ambas listas y eliminar duplicados
var combinedOrderIds = userOrderIds.Union(clientOrderIds);

combinedOrderIds.Dump("IDs combinados (Usuarios y Clientes que han hecho pedidos)");