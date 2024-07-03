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

// Contains - El operador Contiene comprueba si un elemento especificado existe o no en la colección y devuelve un valor booleano.

// 1#
// Lista de nombres de clientes específicos
var specificClientName = new List<string> { "Tech Solutions Inc." };

// Verificar si hay algún cliente con un nombre en la lista específica
bool clienteNameSpecific = Clients.Any(c => specificClientName.Contains(c.Name));
clienteNameSpecific.Dump("Hay algún cliente con un nombre específico en la lista");

// Mostrar todos los clientes
Clients.ToList().Dump("Todos los Clientes");




