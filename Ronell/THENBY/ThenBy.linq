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
IList<Orders> listaOrdenes = Orders.ToList();

//ThenBy ASCENDENTEMENTE
var resultadoThenBy = listaOrdenes.OrderBy(s => s.Client_id).ThenBy(o => o.Total);

//ThenBy DESCENDENTEMENTE
var resultadoThenByDesc = listaOrdenes.OrderBy(s => s.Client_id).ThenByDescending(o => o.Total);


resultadoThenBy.Dump("Resultado con Then by");
