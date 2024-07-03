<Query Kind="Statements">
  <Connection>
    <ID>86e83c00-8332-416e-961a-5b03c8d705ae</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>LAPTOP-FCVS7KOA\SQLEXPRESS</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <Database>Linqpad_ap2</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
</Query>

// ANY - Comprueba si alguno de los elementos de una secuencia satisface la condición especificada

// 1#
bool anyProductBelow10Stock = Products.Any(p => p.Stock <= 100);
anyProductBelow10Stock.Dump("Hay algún producto con un stock menor a 10");

// Mostrar todos los productos
Products.ToList().Dump("Todos los Productos");


// 2#
// Verificar si hay alguna orden con un total mayor a 2000
bool anyOrderAbove2000 = Orders.Any(o => o.Total > 2000);
anyOrderAbove2000.Dump("Hay alguna orden con un total mayor a 2000");

// Mostrar todas las órdenes
Orders.ToList().Dump("Todas las Órdenes");