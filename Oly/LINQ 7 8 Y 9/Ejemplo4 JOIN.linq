<Query Kind="Program" />

using System;
using System.Collections.Generic;
using System.Linq;

public class Product
{ 
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public int CategoryID { get; set; }
}

public class Category
{ 
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
}

class Program
{
    static void Main()
    {
        IList<Product> productList = new List<Product>() {
            new Product() { ProductID = 1, ProductName = "Laptop", CategoryID = 1 },
            new Product() { ProductID = 2, ProductName = "Smartphone", CategoryID = 1 },
            new Product() { ProductID = 3, ProductName = "Tablet", CategoryID = 2 },
            new Product() { ProductID = 4, ProductName = "Monitor", CategoryID = 3 }
        };

        IList<Category> categoryList = new List<Category>() { 
            new Category() { CategoryID = 1, CategoryName = "Electronics" },
            new Category() { CategoryID = 2, CategoryName = "Mobile Devices" },
            new Category() { CategoryID = 3, CategoryName = "Accessories" }
        };

        var innerJoinQuery = from prod in productList
                             join cat in categoryList
                             on prod.CategoryID equals cat.CategoryID
                             select new 
                             {
                                 ProductName = prod.ProductName,
                                 CategoryName = cat.CategoryName
                             };

        foreach (var obj in innerJoinQuery)
            Console.WriteLine($"{obj.ProductName} - {obj.CategoryName}");
    }
}
