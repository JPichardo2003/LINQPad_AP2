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

//GroupBy in Query syntax
IList<Products> listaProductos = Products.ToList();

var resultado1 = from p in listaProductos
                    group p by p.Description;
        
foreach (var descripcionP in resultado1)
{
    Console.WriteLine("Descripcion del producto: {0}", descripcionP.Key);
             
    foreach(Products p in descripcionP)
        Console.WriteLine("Precio del producto: {0}", p.Price);
		
	Console.WriteLine();
}


//GroupBy in method syntax
IList<Products> listaProductos2 = Products.ToList(); 

var resultado2 = listaProductos2.GroupBy(p => p.Description);

foreach (var descripcionPr in resultado2)
{
    Console.WriteLine("Descripción del producto: {0}", descripcionPr.Key);
             
    foreach(Products p in descripcionPr)  
        	Console.WriteLine("Precio del producto: {0}", p.Price);
	Console.WriteLine();
}


//ToLookup in method syntax
IList<Users> listaUsuarios = Users.ToList(); 

var resultadoToLookup = listaUsuarios.ToLookup(s => s.Email);

foreach (var group in resultadoToLookup)
{
    Console.WriteLine("Correo electronico: {0}", group.Key); 
             
    foreach(Users u in group)  
        Console.WriteLine("Nombre del usuario: {0}", u.Name);
		Console.WriteLine();
}
