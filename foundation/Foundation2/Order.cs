using System.Collections.Generic;

class Order
{
    private List<(Product product, int quantity)> _products; // create private list for products in order
    private Customer _customer; // creates private instance of customer object

    private const double _shippingCostUSA = 5.00; // defines default shipping cost for inside the US
    private const double _shippingCostInternational = 35.00; // defines default shipping cost for outside the US

    public Order(Customer customer) // Order class instance (for a particular customer)
    {
        _customer = customer;
        _products = new List<(Product product, int quantity)>();
    }

    public void AddProduct(Product product, int quantity) // Add product to products list
    {
        _products.Add((product, quantity));
    }

    public double CalculateTotalPrice() // calculate the total price of the order
    {
        double totalCost = 0; // define intial cost
        double shippingCost; // create variable for shipping cost

        foreach (var (product, quantity) in _products) // add price of each item in order to total cost
        {
            totalCost += product.GetTotalCost(quantity);
        }

        if (_customer.LivesInUSA() == true) // calculate total cost with shipping in USA
        {
            shippingCost = _shippingCostUSA;
        }
        else // calculate total cost with shipping outside USA
        {
            shippingCost = _shippingCostInternational;
        }

        return totalCost + shippingCost;
    }

    public string GetPackingLabel() // return string value of packing label (list of producst and product ID's)
    {
        string label = "Packing Label:\n";
        foreach (var (product, quantity) in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return label;
    }

    public string GetShippingLabel() // return string value of shipping label (customer name/address)
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";
    }

    public void DisplayOrderDetails() // display packing label, shipping label, and total price of order
    {
        Console.WriteLine(GetPackingLabel());
        Console.WriteLine(GetShippingLabel());
        Console.WriteLine($"Total Price: ${CalculateTotalPrice():F2}\n");
    }
}