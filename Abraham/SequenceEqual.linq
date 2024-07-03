<Query Kind="Statements">
  <Connection>
    <ID>d0880182-244f-4e05-8f89-b24e1c1053c2</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>localhost</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <Database>Linqpad_ap2</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
</Query>

//public class UserComparer : IEqualityComparer<Users>
//{
//   public bool Equals(Users x, Users y)
//    {
//        if (x == null || y == null)
//            return false;
//
//        return x.Id == y.Id && x.Email.ToLower() == y.Email.ToLower();
//    }
//
//    public int GetHashCode(Users obj)
//    {
//        if (obj == null)
//            return 0;
//
//        int hashId = obj.Id.GetHashCode();
//        int hashEmail = obj.Email == null ? 0 : obj.Email.ToLower().GetHashCode();
//
//        return hashId ^ hashEmail;
//    }
//}


// Comparar dos listas de usuarios
var usersnames1 = Users.Take(5).Select(u => u.Username).ToList();
var usersnames2 = Users.Skip(5).Take(5).Select(u => u.Username).ToList();
var usersnames3 = usersnames1;
var usersnames4 = usersnames1;


bool areEqual = usersnames1.SequenceEqual(usersnames2);
areEqual.Dump("¿Son Iguales usersnames1 y usersnames2?");

areEqual = usersnames3.SequenceEqual(usersnames4);
areEqual.Dump("¿Son Iguales usersnames3 y usersnames4?");

//var user1 = Users.Take(1).ToList();
//var user2 = Users.Take(1).ToList();
//areEqual = user1.SequenceEqual(usersnames4);

//bool areUsersEqual = user1.SequenceEqual(user2);




//Obtener el último cliente agregado
//Por cuestiones del c# Statement y los datos vienen de sql, no se puede usar lastOrDefault, en otro archivo hay ejemplos.
var lastClient = Clients.OrderByDescending(c => c.Created_at).FirstOrDefault();
var lastClient2 = Clients.LastOrDefault();
lastClient.Dump("Last client added");
lastClient2.Dump("Last client added");
