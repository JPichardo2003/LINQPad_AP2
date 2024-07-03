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
  <AutoDumpHeading>true</AutoDumpHeading>
</Query>

//1# All
// Verificar si todos los productos tienen un stock mayor a 50
bool allProductsAbove100 = Products.All(p => p.Stock > 50);
allProductsAbove100.Dump("Todos los productos tienen un stock mayor a 50");

// Mostrar todos los productos
Products.ToList().Dump("Todos los Productos");

// 2# All
bool allClientsWithExampleEmail = Clients.All(c => c.Email.EndsWith("example.com"));
allClientsWithExampleEmail.Dump("Todos los clientes tienen un correo electrónico que termina en 'example.com'");

// Mostrar todos los clientes
Clients.ToList().Dump("Todos los Clientes");