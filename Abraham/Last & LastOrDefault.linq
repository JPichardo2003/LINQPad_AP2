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

public class Program
{
	public static void Main()
	{
		IList<int> intList = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
		IList<string> strList = new List<string>() { null, "Two", "Three", "Four", "Five" };
		IList<string> emptyList = new List<string>();
		
		Console.WriteLine("Ultimo elemento de la lista de enteros : {0}", intList.LastOrDefault());
		
		Console.WriteLine("Ultimo elemento par de la lista de enteros : {0}",
						  intList.LastOrDefault(i => i % 2 == 0));
		
		Console.WriteLine("Ultimo elemento de la lista de strings: {0}", strList.LastOrDefault());
		
		Console.WriteLine("Ultimo elemento de la lista vacia: {0}", emptyList.LastOrDefault());
		
		Console.WriteLine("Ultimo elemento de la lista vacia: {0}", emptyList.Last()); //aqui dará error.

	}
}