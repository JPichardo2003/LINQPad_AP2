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

// Aggregate - Realiza una operación de agregación personalizada en los valores de la colección.

// 1#
var clientNames = Clients.Select(c => c.Name).ToList();

// Usar Aggregate para concatenar los nombres de clientes separados por coma
string separarClienteName = clientNames.Aggregate(
    (current, next) => current + ", " + next
);

// Mostrar el resultado usando Dump
separarClienteName.Dump("Nombres de Clientes Concatenados");
