<Query Kind="Statements">
  <Connection>
    <ID>49ee33ed-0ce5-4f4a-9003-8ee915acb224</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-B3DAEPP\SQLEXPRESS</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <Database>Linqpad_ap2</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
</Query>

IList mixedList = new ArrayList();
        mixedList.Add(new Users { Id = 1, Username = "johndoe", Name = "John Doe" });
        mixedList.Add(new Client { Id = 1, Name = "Tech Solutions Inc." });
        mixedList.Add(new Products { Id = 1, Description = "Laptop Lenovo ThinkPad T490", Price = 1200.00m });
        mixedList.Add(new Orders { Id = 1, User_id = 1, Client_id = 1, Total = 1699.99m });
        mixedList.Add("Esto no se va a imprimir");
        mixedList.Add(42);

		//Filtrar Usuarios

        var userResult = from s in mixedList.OfType<String>()
                         select s;

		//Filtrar Clientes
					
        var clientResult = from s in mixedList.OfType<Client>()
                           select s;

		//Filtrar Productos

        var productResult = from s in mixedList.OfType<Products>()
                            select s;

		//Filtrar Ordenes

        var orderResult = from s in mixedList.OfType<Orders>()
                          select s;

        foreach (var user in userResult)
            Console.WriteLine(user);

        foreach (var client in clientResult)
            Console.WriteLine(client.Name);

        foreach (var product in productResult)
            Console.WriteLine(product.Description);

        foreach (var order in orderResult)
            Console.WriteLine(order.Total);