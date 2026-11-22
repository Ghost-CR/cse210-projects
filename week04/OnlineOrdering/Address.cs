// Address stores location details and answers location-related questions for Customer.
public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    // Initialize the address fields used by IsInUSA and GetFullAddress.
    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateProvince = state;
        _country = country;
    }
    // Customer delegates this check to Address, and Order uses the result for shipping cost.
    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        return false;
    }

    // Customer passes this formatted address to Order.GetShippingLabel.
    public string GetFullAddress()
    {
        return  $"{_streetAddress}{Environment.NewLine}" +
                $"{_city}, {_stateProvince}{Environment.NewLine}" +
                $"{_country}";
    }
}
