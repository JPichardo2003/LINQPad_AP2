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

//LINQ Method Syntax

var userListMethod = Users
    .Select(user => new 
    {
        Username = user.Username,
        Email = user.Email
    })
    .ToList();

userListMethod.Dump();

//LINQ Query Syntax

var UserListQuery = from user in Users
 select new 
 {
     Username = user.Username,
     Email = user.Email
 };

UserListQuery.Dump();

