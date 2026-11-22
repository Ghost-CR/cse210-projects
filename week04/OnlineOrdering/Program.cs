using System;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Order> orders = new List<Order>();

        Address address1 = new Address(
            "123 Main Street", "Rexburg", "Idaho", "USA");
        Customer customer1 = new Customer("Ana García", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Notebook", 101, 4.50, 2));
        order1.AddProduct(new Product("Pen", 102, 1.25, 3));
        orders.Add(order1);

        Address address2 = new Address(
            "Av. Arequipa 123", "Lima", "Lima", "Peru");
        Customer customer2 = new Customer("Luis Pérez", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Backpack", 201, 28.00, 1));
        order2.AddProduct(new Product("Water bottle", 202, 12.50, 2));
        orders.Add(order2);

        Address address3 = new Address(
            "45 Maple Road", "Toronto", "Ontario", "Canada");
        Customer customer3 = new Customer("Sofia Chen", address3);
        Order order3 = new Order(customer3);
        order3.AddProduct(new Product("Desk lamp", 301, 19.99, 1));
        order3.AddProduct(new Product("Notebook", 302, 4.50, 4));
        order3.AddProduct(new Product("Pen", 303, 1.25, 2));
        orders.Add(order3);

        foreach (Order order in orders)
        {
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total: ${order.CalculateTotalCost():F2}");
            Console.WriteLine();
        }
    }
}