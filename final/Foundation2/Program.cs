using System;

class Program
{
    static void Main(string[] args)
    {
        // Customer 1 (USA)
        Address addr1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer cust1 = new Customer("Alice Johnson", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Notebook", "NB001", 4.50m, 3));
        order1.AddProduct(new Product("Pen", "PN001", 1.25m, 5));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        // Customer 2 (International)
        Address addr2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Bob Smith", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Sketchbook", "SK101", 7.75m, 2));
        order2.AddProduct(new Product("Pencil", "PC202", 0.99m, 10));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}
