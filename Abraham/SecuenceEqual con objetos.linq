<Query Kind="Program">
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

public class Users
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
}

public class UserComparer : IEqualityComparer<Users>
{
    public bool Equals(Users x, Users y)
    {
        if (x == null || y == null)
            return false;

        return x.Id == y.Id && x.Email.ToLower() == y.Email.ToLower();
    }

    public int GetHashCode(Users obj)
    {
        if (obj == null)
            return 0;

        int hashId = obj.Id.GetHashCode();
        int hashEmail = obj.Email == null ? 0 : obj.Email.ToLower().GetHashCode();

        return hashId ^ hashEmail;
    }
}

public class Program
{
    public static void Main()
    {
        List<Users> userList = GetUsersFromDatabase();
		
		var users1 = userList.Take(1);
		var users2 = userList.Skip(1).Take(1);
		
		bool equal = users1.SequenceEqual(users2);
		bool equal2 = users1.SequenceEqual(users2, new UserComparer());
		
		equal.Dump();
		equal2.Dump();
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    

    public static List<Users> GetUsersFromDatabase()
    {
        return new List<Users>
        {
            new Users { Id = 1, Username = "john_doe", Name = "John Doe", Email = "john@example.com" },
            new Users { Id = 1, Username = "john_doe", Name = "John Doe", Email = "john@example.com" },
            new Users { Id = 3, Username = "sam_smith", Name = "Sam Smith", Email = "sam@example.com" },
            new Users { Id = 4, Username = "lucy_lu", Name = "Lucy Lu", Email = "lucy@example.com" },
            new Users { Id = 5, Username = "mark_z", Name = "Mark Z", Email = "mark@example.com" },
            new Users { Id = 6, Username = "paul_p", Name = "Paul P", Email = "paul@example.com" },
            new Users { Id = 7, Username = "kate_k", Name = "Kate K", Email = "kate@example.com" },
            new Users { Id = 8, Username = "amy_a", Name = "Amy A", Email = "amy@example.com" },
            new Users { Id = 9, Username = "bob_b", Name = "Bob B", Email = "bob@example.com" },
            new Users { Id = 10, Username = "carl_c", Name = "Carl C", Email = "carl@example.com" }
        };
    }
}
