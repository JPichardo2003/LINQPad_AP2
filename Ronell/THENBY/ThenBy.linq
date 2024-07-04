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
</Query>

//ThenBy & ThenByDescending

//ThenBy ASCENDENTEMENTE
var resultadoThenBy = Orders.OrderBy(s => s.Client_id).ThenBy(o => o.Total);

//ThenBy DESCENDENTEMENTE
var resultadoThenByDesc = Orders.OrderBy(s => s.User_id).ThenByDescending(o => o.Total);


resultadoThenBy.Dump("Resultado con Then by ascendente");

resultadoThenByDesc.Dump("Resultado con Then by descendente");
