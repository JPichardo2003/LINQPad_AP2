<Query Kind="Statements">
  <Connection>
    <ID>d0880182-244f-4e05-8f89-b24e1c1053c2</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>localhost</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <Database>Linqpad_ap2</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
</Query>

 string emailToSearch = "techsolutions@example.com";
 string emailToSearch2 = "techsolution@example.com";

    var client = Clients.SingleOrDefault(c => c.Email == emailToSearch);
    if (client != null)
    {
        client.Dump();
    }
    else
    {
        "No se encontró ningún cliente con ese correo electrónico.".Dump();
    }
	
	client = Clients.SingleOrDefault(c => c.Email == emailToSearch2);
    if (client != null)
    {
        client.Dump();
    }
    else
    {
        "No se encontró ningún cliente con ese correo electrónico.".Dump();
    }
	
    client = Clients.SingleOrDefault(c => c.Name == "prueba");
	client = Clients.SingleOrDefault(c => c.Name == "prueba");
