using System;
using System.Collections.Generic;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Category { get; set; }

    public Product(int id, string name, string category)
    {
        ProductId = id;
        ProductName = name;
        Category = category;
    }
    public override string ToString()
    {
        return $"id :{ProductId} - name : {ProductName} - categry:{Category}";
    }
}
class Program
{
    static void Main()
    {
        var products = new List<Product>
        {
            new Product(109 , "Headphone" , "Electronics" ),
            new Product(107, "Notebook" , "Stationary" ),
            new Product(101 , "Shampoo" , "Hair care" )

        };
        //SORTING IT TO APPLY SEARCHING ALGO

        products.Sort((p1, p2) => p1.ProductId.CompareTo(p2.ProductId));

        int searchId = 107;

        //LINEAR SEARCH
        var result1 = LinearSearch(products, searchId);
        Console.WriteLine("Linear Search Results : " + (result1 != null ? result1.ToString() : "Not FOund"));

        //BINARY SEARCH
        var result2 = BinarySearch(products, searchId);
        Console.WriteLine("Binary Search Results : " + (result2 != null ? result2.ToString() : "Not FOund"));
    }
    public static Product LinearSearch(List<Product> products, int targetId)
    {
        foreach (var product in products)
        {
            if (product.ProductId == targetId)
            {
                return product; // RETURN THE PRODUCT NAME WITH SEARCHID AND CATEGORY
            }
        }
        return null; // NOT FOUND IN THE LIST OF PRODUCTS
    }
    public static Product BinarySearch(List<Product> product, int targetID)
    {
        int low = 0;
        int high = product.Count - 1; // ARRAY INDEX START FROM 0

        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (product[mid].ProductId == targetID)
            {
                return product[mid];
            }
            else if (product[mid].ProductId < targetID)
            {
                low = mid + 1;   // eliminating the left search space as the target element is greater than mid
            }
            else
            {
                high = mid - 1;   // eliminating the right search space as the target element is smaller than mid
            }
        }
        return null;
    }
}