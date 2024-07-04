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

var usersList = Users.ToList();
usersList.Dump();

var productsArray = Products.ToArray();
productsArray.Dump();

var ordersDictionary = Orders.ToDictionary(o => o.Id);
ordersDictionary.Dump();

var usersEnumerable = Users.AsEnumerable();
usersEnumerable.Dump();

//Convertir clientes a un arreglo de emails:
var ClientEmails = Clients.Select(c => c.Email)
                                .ToArray();
ClientEmails.Dump();

//Convertir usuarios a un diccionario con username como clave y name como valor:
var userDictionary = Users.ToDictionary(u => u.Username, u => u.Name);
userDictionary.Dump();

//Convertir órdenes a un IEnumerable con OrderId y Total:
var orderSummaries = Orders.Select(o => new { OrderId = o.Id, Total = o.Total })
                           .AsEnumerable();
orderSummaries.Dump();

//Convertir una lista no genérica de productos a una lista genérica:
ArrayList productArrayList = new ArrayList(Products.ToList());
var genericProductList = productArrayList.Cast<Products>().ToList();
genericProductList.Dump();

//Filtrar productos a partir de un objeto IEnumerable y convertir a List<Product>:
IEnumerable products = Products.AsEnumerable();
var filteredProducts = products.Cast<Products>()
                               .Where(p => p.Price > 500)
                               .ToList();
filteredProducts.Dump();