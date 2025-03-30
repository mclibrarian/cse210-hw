using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order();
        order1.SetCustomer(new Customer("Maude Beeson", new Address("1300 Lake Lane", "Highville", "Maryland", "United States")));
        order1.AddProduct(new Product("Cow", 1, 600, 1));
        order1.AddProduct(new Product("Goat", 2, 400, 2));
        order1.AddProduct(new Product("Chicken", 3, 50, 10));
        Console.WriteLine(order1.ReturnPackingLabel());
        Console.WriteLine(order1.ReturnShippingLabel());
        Console.WriteLine(order1.TotalPrice());
        Console.WriteLine();

        Order order2 = new Order();
        order2.SetCustomer(new Customer("George Anders", new Address("Frog Hall", "Goodtowne", "Shropshire", "United Kingdom")));
        order2.AddProduct(new Product("Horse", 4, 1200, 1));
        order2.AddProduct(new Product("Pig", 5, 500, 4));
        order2.AddProduct(new Product("Chicken", 3, 50, 7));
        Console.WriteLine(order2.ReturnPackingLabel());
        Console.WriteLine(order2.ReturnShippingLabel());
        Console.WriteLine(order2.TotalPrice());
    }
}