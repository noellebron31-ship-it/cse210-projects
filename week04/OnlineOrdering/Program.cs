using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: Client in the USA
        Address address1 = new Address("123 Main St", "Anytown", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new product("Laptop", "LAP123", 999.99, 1));
        order1.AddProduct(new product("Mouse", "MOU456", 25.50, 2));

    //order 2: Client outside the USA
        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");
        Customer customer2 = new Customer("Jane Smith", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new product("Smartphone", "SMA789", 499.99, 1));
        order2.AddProduct(new product("Headphones", "HEA012", 89.99, 1));

        // Display order details
        displayOrderDetails(order1);
        Console.WriteLine("\n" + new string ('=', 40) + "\n");
        displayOrderDetails(order2);
    }

    static void displayOrderDetails(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():F2}");
    }
}