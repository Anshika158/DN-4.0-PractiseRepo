using System;
using System.Collections.Generic;

namespace InventoryManagementSystem
{
    class Product
    {
        public int ProductId { get; set; } //for unique id of the product
        public string ProductName { get; set; } //product name
        public int Quantity { get; set; } //product Quantity
        public double ProductPrice { get; set; } // product cost

        public Product(int id, string name, int qty, double price)
        {
            ProductId = id;
            ProductName = name;
            Quantity = qty;
            ProductPrice = price;
        }
        public override string ToString()
        {
            return $"id : {ProductId} , name :{ProductName} , qty : {Quantity} , price :{ProductPrice}";
        }
    }
    class InventoryManager
    {
        private Dictionary<int, Product> inventory = new Dictionary<int, Product>();
        public void AddProduct(Product product)   // function to add item in the inventory
        {
            if (!inventory.ContainsKey(product.ProductId))  //if-else statement to check if item is not there it will add the itme in the inventory otherwsie it will show itme alrrady exist.
            {
                inventory[product.ProductId] = product;
                Console.WriteLine("Product is added . ");
            }
            else
            {
                Console.WriteLine("Product is already added / exists .");
            }
        }
        public void UpdateProduct(int id, int qty, double price)  //function to update the item in the inventory
        {
            if (inventory.ContainsKey(id))
            {
                inventory[id].Quantity = qty;
                inventory[id].ProductPrice = price;
                Console.WriteLine("Product is been updated in the inventory . ");
            }
            else
            {
                Console.WriteLine("Product id not found");
            }
        }
        public void deleteProduct(int id)     //funtion to delete the item from the inventory
        {
            if (inventory.Remove(id))
            {
                Console.WriteLine("Product is deleted fom the inventory");
            }
            else
            {
                Console.WriteLine("Product id not found");
            }
        }
        public void displayInventory()
        {
            Console.WriteLine("\n Inventory : ");
            foreach (var product in inventory.Values)
            {
                Console.WriteLine(product);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            InventoryManager manager = new InventoryManager();

            manager.AddProduct(new Product(101, "Soap", 10, 50)); //calling the function to add the product in the inventory
            manager.AddProduct(new Product(102, "Shampoo", 5, 280));

            manager.displayInventory();  // calling the function to display it

            manager.UpdateProduct(102, 12, 270);  // calling the function to update the invemtory
            manager.displayInventory();

            manager.deleteProduct(101);  // calling the function to delete it
            manager.displayInventory();
        }
    }
}