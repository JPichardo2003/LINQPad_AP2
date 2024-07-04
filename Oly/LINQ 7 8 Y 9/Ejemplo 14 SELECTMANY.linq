<Query Kind="Program" />

using System;
using System.Collections.Generic;
using System.Linq;

public class Order
{
    public int OrderID { get; set; }
    public string OrderName { get; set; }
    public List<Product> Products { get; set; }
}

public class Product
{
    public int ProductID { get; set; }
    public string ProductName { get; set; }
}

class Program
{
    static void Main()
    {
        IList<Order> orderList = new List<Order>() {
            new Order() { OrderID = 1, OrderName = "Order 1", Products = new List<Product>() {
                new Product() { ProductID = 1, ProductName = "Laptop" },
                new Product() { ProductID = 2, ProductName = "Mouse" }
            }},
            new Order() { OrderID = 2, OrderName = "Order 2", Products = new List<Product>() {
                new Product() { ProductID = 3, ProductName = "Keyboard" },
                new Product() { ProductID = 4, ProductName = "Monitor" }
            }},
            new Order() { OrderID = 3, OrderName = "Order 3", Products = new List<Product>() {
                new Product() { ProductID = 5, ProductName = "Printer" }
            }}
        };

        var selectManyResult = orderList.SelectMany(
            order => order.Products,
            (order, product) => new { OrderName = order.OrderName, ProductName = product.ProductName }
        );

        foreach (var item in selectManyResult)
        {
            Console.WriteLine($"Order: {item.OrderName}, Product: {item.ProductName}");
        }
    }
}
