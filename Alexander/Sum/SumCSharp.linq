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




//Sumar y optener el numero de clientes mediante SUM
var totalClients = Clients.ToList().Sum(s =>{
	if(s.Name != null)
		return 1;
	
	else
		return 0;
});

totalClients.Dump();


//Optener el monto total que se tiene en inventario de producto

var MontoEnInvetario = (from p in Products.ToList()
						group p by p.Id into m
						select new { producto = Products.FirstOrDefault(pn => pn.Id == m.Key),
									 montoEnInvetario = m.Sum(s => s.Price * s.Stock)} 
);

MontoEnInvetario.Dump();



Products.Dump();



// Obtener el monto total por User_id con sum 
 var totalPerUser = Orders.ToList()
        .GroupBy(o => o.User_id)
        .Select(g => new
        {
            UserId = g.Key,
            TotalAmount = g.Sum(o => o.Total),
			Name = (from c in Clients where c.Id == g.Key select c.Name)
        })
        .ToList();

totalPerUser.Dump();


(from o in Orders group o by o.User_id).Dump();


