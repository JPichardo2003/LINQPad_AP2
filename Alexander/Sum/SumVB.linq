<Query Kind="VBStatements">
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

' Obtener el monto total por User_id con sum

Dim totalPerUser = From o In Orders.ToList()
                   Group o By o.User_id Into g = Group
                   Select New With {
                       .UserId = User_id,
                       .TotalAmount = g.Sum(Function(o) o.Total),
                       .Name = (From c In Clients Where c.Id = User_id Select c.Name).FirstOrDefault()
                   }

Dim result = totalPerUser.ToList()
result.Dump()
