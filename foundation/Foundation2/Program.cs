using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        var address1 = new Address("1234 S Main St", "Salt Lake City", "UT", "USA"); // create address for 1st customer
        var address2 = new Address("5678 Center Ave", "Toronto", "ON", "Canada"); // create address for 2nd customer

        // Create customers
        var customer1 = new Customer("John Smith", address1); // create 1st customer object
        var customer2 = new Customer("Marley Robinson", address2); // create 2nd customer object

        // Define products
        var product1 = new Product("Product 1 name", 20403, 6.50);
        var product2 = new Product("Product 2 name", 32185, 4.52);
        var product3 = new Product("Product 3 name", 63016, 17.25);
        var product4 = new Product("Product 4 name", 19941, 1.99);

        // Create orders for each customer
        var order1 = new Order(customer1);
        order1.AddProduct(product1, 5);
        order1.AddProduct(product2, 2);
        order1.AddProduct(product4, 7);

        var order2 = new Order(customer2);
        order2.AddProduct(product3, 1);
        order2.AddProduct(product4, 10);

        // Display order details
        order1.DisplayOrderDetails();
        order2.DisplayOrderDetails();
    }
}