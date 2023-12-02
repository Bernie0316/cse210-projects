using System;

class Program
{
    static void Main(string[] args)
    {
        var customerAddress1 = new Address("19 Wanan St", "Pingdong", "Taiwan", "Taiwan");
        var customerAddress2 = new Address("456 Idk St", "Youknow", "UT", "USA");
        var customer1 = new Customer("John Doe", customerAddress1);
        var customer2 = new Customer("Jane Smith", customerAddress2);

        var products1 = new List<Product>
        {
            new Product("Product1", "1", 10.99, 2),
            new Product("Product2", "2", 20.49, 1),
        };
        var order1 = new Order(products1, customer1);
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.PackLabel());
        Console.WriteLine(order1.ShipLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalOrderCost()}");
        Console.WriteLine();

        var products2 = new List<Product>
        {
            new Product("Product3", "3", 15.99, 3),
            new Product("Product4", "4", 18.75, 2),
        };
        var order2 = new Order(products2, customer2);
        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.PackLabel());
        Console.WriteLine(order2.ShipLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalOrderCost()}");
    }
}