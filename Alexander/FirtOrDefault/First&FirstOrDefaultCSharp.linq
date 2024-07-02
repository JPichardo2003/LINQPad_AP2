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

  
   // Obtener el primer pedido realizado por un usuario con un nombre que contenga una a
        var firstOrDefaultOrderName = Orders.ToList()
                           .Join(Users.ToList(), o => o.User_id, u => u.Id, (o, u) => new { o, u })
                           .FirstOrDefault(ou => ou.u.Name.Contains("Z"));
        
		if(firstOrDefaultOrderName != null){
			Console.WriteLine($"ID del pedido: {firstOrDefaultOrderName.o.Id}");
	        Console.WriteLine($"Usuario que hizo el pedido: {firstOrDefaultOrderName.u.Name}");
	        Console.WriteLine($"Total del pedido: {firstOrDefaultOrderName.o.Total:C}");
		}
		else{
			Console.WriteLine($"No hay usuario con esa letra {firstOrDefaultOrderName}");
		}
		
		// o
		
		var firstOrderName = Orders.ToList()
                           .Join(Users.ToList(), o => o.User_id, u => u.Id, (o, u) => new { o, u })
                           .First(ou => ou.u.Name.Contains("Z"));
        
		if(firstOrderName != null){
			Console.WriteLine($"ID del pedido: {firstOrderName.o.Id}");
	        Console.WriteLine($"Usuario que hizo el pedido: {firstOrderName.u.Name}");
	        Console.WriteLine($"Total del pedido: {firstOrderName.o.Total:C}");
		}
		else{
			Console.WriteLine($"No hay usuario con esa letra {firstOrderName}");
		}
		
       
  
  
  
  //obtener el primer pedido realizado por un usuario en la tabla Orders, incluyendo información del usuario y del cliente.
  var firstOrder = Orders.ToList()
                            .Join(Users.ToList(), o => o.User_id, u => u.Id, (o, u) => new { o, u })
                            .Join(Clients.ToList(), ou => ou.o.Client_id, c => c.Id, (ou, c) => new { ou.o, ou.u, c })
                            .OrderBy(ouc => ouc.o.Id)
                            .First();
        
        Console.WriteLine($"ID del primer pedido: {firstOrder.o.Id}");
        Console.WriteLine($"Usuario que hizo el pedido: {firstOrder.u.Name}");
        Console.WriteLine($"Cliente para el pedido: {firstOrder.c.Name}");
        Console.WriteLine($"Total del pedido: {firstOrder.o.Total:C}");
		
		
	// Obtener el primer producto con un precio mayor a 1000.00
        var firstOrDefaultProduct = Products.ToList().OrderBy(p => p.Description).FirstOrDefault(p => p.Price > (Decimal)1000.00);
        
        if (firstOrDefaultProduct != null)
        {
            Console.WriteLine($"ID del producto: {firstOrDefaultProduct.Id}");
            Console.WriteLine($"Descripción del producto: {firstOrDefaultProduct.Description}");
            Console.WriteLine($"Precio del producto: {firstOrDefaultProduct.Price:C}");
        }
        else
        {
            Console.WriteLine("No se encontró ningún producto con un precio mayor a 1000.00.");
        }
		
		(from p in Products select p).Dump();