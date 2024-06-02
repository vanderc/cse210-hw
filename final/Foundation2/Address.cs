public class Address
{
    private string _streetAddress;

    private string _city;

    private string _stateProvince;

    private string _country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city =city;
        _stateProvince = stateProvince;
        _country = country;
    }

    public string GetCountry()
    {
        return _country;
    }

    public string GetShippingInfo(Customer customer)
    {
        return $"{customer.GetCustomerName()}\n{_streetAddress}\n{_city}, {_stateProvince}, {_country}";
    }
}