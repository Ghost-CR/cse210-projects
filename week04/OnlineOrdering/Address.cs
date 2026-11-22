public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _stateProvince = state;
        _country = country;
    }
    public bool IsInUSA()
    {
        if(_country == "USA")
        {
            return true;
        }
        return false;
    }

    public string GetFullAddress()
    {
        return  $"{_streetAddress}{Environment.NewLine}" +
                $"{_city}, {_stateProvince}{Environment.NewLine}" +
                $"{_country}";
    }
}