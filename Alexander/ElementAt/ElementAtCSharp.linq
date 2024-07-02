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

//Ejemplo #1 basico para ElementAt
   var firstUser = Users.ToList()
        .ElementAt(0);

	firstUser.Dump();
	
	(from u in Users select u).Dump();
	
	
//Ejemplo #2 basico para ElementAt
	
	var secondProduct = Products.OrderBy(p => p.Id).ToList().ElementAt(1);
        
        Console.WriteLine($"Descripción del producto: {secondProduct.Description}");
        Console.WriteLine($"Precio del producto: {secondProduct.Price:C}");
	
	
//Ejemplo #1 basico para ElementAtOrDefault
   var secondUser = Users.ToList()
        .ElementAtOrDefault(22);

	secondUser.Dump();
	
	(from u in Users select u).Dump();
	
	
//Ejemplo #2 basico para ElementAtOrDefault

 var tenthProduct = Products.ToList().OrderBy(p => p.Id).ElementAtOrDefault(9);
        
        if (tenthProduct != null)
        {
            Console.WriteLine($"Descripción del producto: {tenthProduct.Description}");
            Console.WriteLine($"Precio del producto: {tenthProduct.Price:C}");
        }
        else
        {
            Console.WriteLine("No se encontró el décimo producto.");
        }