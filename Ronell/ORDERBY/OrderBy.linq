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
IList<Users> listaUsuarios = Users.ToList();

var orderByResult = from s in listaUsuarios
                   orderby s.Id 
                   select s;

var orderByDescendingResult = from s in listaUsuarios
                   orderby s.Id descending
                   select s;

orderByResult.Dump("Resultado con OrderBy descendentemente");


//ORDENANDO DE MANERA ASCENDENTE
IList<Products> listaUsuarios2 = Products.ToList();

var productosOrdenAscendente = listaUsuarios2.OrderBy(p => p.Description);

productosOrdenAscendente.Dump("Resultado con OrderBy ascendentemente");


//ORDENANDO DE MANERA DESCENDENTEMENTE
IList<Products> listaProductos = Products.ToList();

var productosOrdenDescendente = listaProductos.OrderByDescending(p => p.Description);

productosOrdenDescendente.Dump("Resultado con OrderBy descendemente");


//ORDENACION MULTIPLE CON LA SINTAXIS EN QUERY
IList<Products> listaProductos3 = Products.ToList();

var productosOrdenadosMultiple = from p in listaProductos3
                   orderby p.Description, p.Price, p.Stock
                   select new { p.Description, p.Price, p.Stock };

productosOrdenadosMultiple.Dump("Resultado con OrderBy");