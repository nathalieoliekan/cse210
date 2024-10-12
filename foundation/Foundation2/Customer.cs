class Customer
{
    private string _name; // create variable for customer name
    private Address _address; // create private variable here for address instance

    public Customer(string name, Address address) // customer class instance
    {
        _name = name;
        _address = address;
    }

    public string GetName() // return name of customer
    {
        return _name;
    }

    public Address GetAddress() // return customer address
    {
        return _address;
    }

    public bool LivesInUSA() // return true/false if customer lives in USA
    {
        return _address.IsInUSA();
    }
}