class Address
{
    private string _street; // create variable for street name/number
    private string _city; // create variable for city name
    private string _state; // create variable for state/province name
    private string _country; // create name for country

    public Address(string street, string city, string state, string country) // Address class - to create an address instance
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetFullAddress() // get string address (combined pieces)
    {
        return $"{_street}\n{_city}, {_state}\n{_country}";
    }

    public bool IsInUSA() // if statement to return if address is in USA or not
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}