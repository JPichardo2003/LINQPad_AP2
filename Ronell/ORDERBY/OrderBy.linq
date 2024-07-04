<Query Kind="Statements">
  <Connection>
    <ID>14038c7e-ff62-4bd0-8300-9410995da079</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>LAPTOP-33BTRVPP\SQLEXPRESS</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <Database>Linqpad_ap2</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
  <AutoDumpHeading>true</AutoDumpHeading>
</Query>

// OrderBy in Query Syntax C#
var orderByResult = from s in Users
                   orderby s.Id 
                   select s;
				   
orderByResult.Dump("Resultado con OrderBy ascendentemente");

var orderByDescendingResult = from s in Users
                   orderby s.Id descending
                   select s;


orderByDescendingResult.Dump("Resultado con OrderBy descendentemente");


//ORDENANDO DE MANERA ASCENDENTE
var productosOrdenAscendente = Products.OrderBy(p => p.Description);

productosOrdenAscendente.Dump("Resultado con OrderBy ascendentemente");


//ORDENANDO DE MANERA DESCENDENTEMENTE
var productosOrdenDescendente = Products.OrderByDescending(p => p.Description);

productosOrdenDescendente.Dump("Resultado con OrderBy descendemente");


//ORDENACION MULTIPLE CON LA SINTAXIS EN QUERY
var productosOrdenadosMultiple = from p in Products
                   orderby p.Description, p.Price, p.Stock
                   select new { p.Description, p.Price, p.Stock };

productosOrdenadosMultiple.Dump("Resultado con OrderBy");