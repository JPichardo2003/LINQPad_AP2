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

// .Where con LINQ Method Syntax

var whereMethod = Products
    .Where(product => product.Price > 1000 && product.Stock > 20)
    .Select(product => new 
    {
        Description = product.Description,
        Price = product.Price,
        Stock = product.Stock
    })
    .ToList();

whereMethod.Dump();

// .Where con LINQ Query Syntax

var whereQuery = (from product in Products
             where product.Price < 1000 && product.Stock > 20
             select new 
             {
                 Description = product.Description,
                 Price = product.Price,
                 Stock = product.Stock
             }).ToList();

whereQuery.Dump();

//Mostrar todos

var products = (from product in Products
                select new 
                {
                    Description = product.Description,
                    Price = product.Price,
                    Stock = product.Stock,
                }).ToList();

products.Dump();