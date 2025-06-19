using System;
using System.Collections.Generic;

public class Order
{
    public int OrderId { get; set; }
    public string CustomerName { get; set; }
    public double TotalPrice { get; set; }

    public Order(int orderId, string customerName, double totalPrice)
    {
        OrderId = orderId;
        CustomerName = customerName;
        TotalPrice = totalPrice;
    }

    public override string ToString()
    {
        return $"OrderID: {OrderId}, Name: {CustomerName}, Price: {TotalPrice}";
    }
}

public class Sorter
{
    public static void BubbleSort(List<Order> orders)
    {
        int n = orders.Count;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (orders[j].TotalPrice > orders[j + 1].TotalPrice)
                {
                    var temp = orders[j];
                    orders[j] = orders[j + 1];
                    orders[j + 1] = temp;
                }
            }
        }
    }

    public static void QuickSort(List<Order> orders, int low, int high)
    {
        if (low < high)
        {
            int pi = Partition(orders, low, high);
            QuickSort(orders, low, pi - 1);
            QuickSort(orders, pi + 1, high);
        }
    }

    private static int Partition(List<Order> orders, int low, int high)
    {
        double pivot = orders[high].TotalPrice;
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (orders[j].TotalPrice < pivot)
            {
                i++;
                var temp = orders[i];
                orders[i] = orders[j];
                orders[j] = temp;
            }
        }

        var temp2 = orders[i + 1];
        orders[i + 1] = orders[high];
        orders[high] = temp2;

        return i + 1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>
        {
            new Order(101, "Alice", 320.0),
            new Order(102, "Bob", 150.5),
            new Order(103, "Charlie", 450.0),
            new Order(104, "David", 280.0)
        };

        Console.WriteLine("Original Orders:");
        foreach (var order in orders) Console.WriteLine(order);

        // Bubble Sort
        var bubbleSorted = new List<Order>(orders);
        Sorter.BubbleSort(bubbleSorted);
        Console.WriteLine("\nOrders after Bubble Sort:");
        foreach (var order in bubbleSorted) Console.WriteLine(order);

        // Quick Sort
        var quickSorted = new List<Order>(orders);
        Sorter.QuickSort(quickSorted, 0, quickSorted.Count - 1);
        Console.WriteLine("\nOrders after Quick Sort:");
        foreach (var order in quickSorted) Console.WriteLine(order);
    }
}
