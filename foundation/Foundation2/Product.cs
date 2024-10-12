class Product
{
    private string _name; // create variable for product name
    private int _productId; // create variable for product ID
    private double _price; // create variable for product price

    public Product(string name, int productId, double price) // Product class instance
    {
        _name = name;
        _productId = productId;
        _price = price;
    }

    public string GetName() // get product name
    {
        return _name;
    }

    public int GetProductId() // get product ID
    {
        return _productId;
    }

    public double GetTotalCost(int quantity) // calculate and return product total cost
    {
        return _price * quantity;
    }
}
