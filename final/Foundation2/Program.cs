using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create some products
        Product product1 = new Product("Product 1", "P1", 10, 2);
        Product product2 = new Product("Product 2", "P2", 20, 1);
        Product product3 = new Product("Product 3", "P3", 30, 3);
        Product product4 = new Product("Product 4", "P4", 40, 1);

        // Create some customers
        Customer customer1 = new Customer("Customer 1", new Address("123 Main St", "Springfield", "IL", "USA"));
        Customer customer2 = new Customer("Customer 2", new Address("456 Elm St", "Shelbyville", "IL", "USA"));
        Customer customer3 = new Customer("Customer 3", new Address("789 Oak St", "Capital City", "IL", "Canada"));

        // Create some orders
        Order order1 = new Order(new List<Product> { product1, product2 }, customer1);
        Order order2 = new Order(new List<Product> { product3 }, customer2);
        Order order3 = new Order(new List<Product> { product4 }, customer3);

        // Add the orders to a list
        List<Order> orders = new List<Order>();
        orders.Add(order1);
        orders.Add(order2);
        orders.Add(order3);

        // Display information about each order
        foreach (Order order in orders)
        {
            Console.WriteLine($"Customer: {order.Customer.Name}");
            Console.WriteLine($"Shipping address:");
            Console.WriteLine(order.Customer.Address.ToString());
            Console.WriteLine($"Total price: ${order.GetTotalPrice():0.00}");
            Console.WriteLine();
        }
    }
}
