<Query Kind="Statements">
  <Connection>
    <ID>f2531828-fb99-4667-8514-788ff8911146</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>ALEXANDER</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <Database>Linqpad_ap2</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
</Query>

//Ejemplo basico para ElementAt
   var firstUser = Users.ToList()
        .ElementAt(0);

	firstUser.Dump();
	
	(from u in Users select u).Dump();
	
	
//Ejemplo basico para ElementAtOrDefault
   var secondUser = Users.ToList()
        .ElementAtOrDefault(22);

	secondUser.Dump();
	
	(from u in Users select u).Dump();