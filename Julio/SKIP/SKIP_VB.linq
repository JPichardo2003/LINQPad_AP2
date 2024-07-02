<Query Kind="VBStatements">
  <Connection>
    <ID>c43cc22d-c32e-42de-b1c6-9361887ce4d8</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>DESKTOP-BHFJURU\SQLEXPRESS</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <Database>Linqpad_ap2</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
</Query>

' #1
' Saltar usuarios hasta encontrar uno con el nombre que empiece con 'C'
Dim skippedUsers = Users.ToList() 	
Dim result = From u IN skippedUsers
			 Skip While NOT u.name.StartsWith("C")
			 Select u
result.Dump()

' #2
' saltar productos mientras el precio sea menor a $500
Dim skippedProducts = Products.ToList()
Dim result2 = From p IN skippedProducts
		     SKIP WHILE NOT p.price < 500
			 SELECT p
result2.Dump()
skippedProducts.Dump()
