using System;

class Program
{
    static void Main(string[] args)
    {
        // --- Order 1: USA Customer ---
        Address addr1 = new Address("123 Apple St", "Cupertino", "CA", "USA");
        Customer cust1 = new Customer("John Doe", addr1);
        Order order1 = new Order(cust1);

        order1.AddProduct(new Product("Wireless Mouse", "M001", 25.99, 2));
        order1.AddProduct(new Product("Mechanical Keyboard", "K042", 89.00, 1));

        // --- Order 2: International Customer ---
        Address addr2 = new Address("456 Mango Ave", "Cebu City", "Cebu", "Philippines");
        Customer cust2 = new Customer("Rowena Cuyasen", addr2);
        Order order2 = new Order(cust2);

        order2.AddProduct(new Product("USB-C Hub", "H112", 45.00, 1));
        order2.AddProduct(new Product("Webcam HD", "W990", 60.00, 1));
        order2.AddProduct(new Product("Monitor Stand", "S555", 30.50, 2));

        // --- Display Results ---
        DisplayOrderDetails(order1, 1);
        Console.WriteLine(new string('-', 30));
        DisplayOrderDetails(order2, 2);
    }

    static void DisplayOrderDetails(Order order, int orderNum)
    {
        Console.WriteLine($"--- DETAILS FOR ORDER #{orderNum} ---");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Order Price: ${order.CalculateTotalCost():F2}\n");
    }
}