<Query Kind="Program" />

using System;
using System.Collections.Generic;
using System.Linq;

public class Customer
{
    public int CustomerID { get; set; }
    public string CustomerName { get; set; }
}

public class Order
{
    public int OrderID { get; set; }
    public string OrderName { get; set; }
    public int CustomerID { get; set; }
}

class Program
{
    static void Main()
    {
        IList<Customer> customerList = new List<Customer>() {
            new Customer() { CustomerID = 1, CustomerName = "Alice" },
            new Customer() { CustomerID = 2, CustomerName = "Bob" },
            new Customer() { CustomerID = 3, CustomerName = "Charlie" }
        };

        IList<Order> orderList = new List<Order>() {
            new Order() { OrderID = 1, OrderName = "Order 1", CustomerID = 1 },
            new Order() { OrderID = 2, OrderName = "Order 2", CustomerID = 1 },
            new Order() { OrderID = 3, OrderName = "Order 3", CustomerID = 2 },
            new Order() { OrderID = 4, OrderName = "Order 4", CustomerID = 3 }
        };

        var groupJoinQuery = from customer in customerList
                             join order in orderList
                             on customer.CustomerID equals order.CustomerID
                             into orderGroup
                             select new
                             {
                                 CustomerName = customer.CustomerName,
                                 Orders = orderGroup
                             };

        foreach (var customer in groupJoinQuery)
        {
            Console.WriteLine(customer.CustomerName);
            foreach (var order in customer.Orders)
            {
                Console.WriteLine($"  {order.OrderName}");
            }
        }
    }
}
