// A Customer connects the person's name with their Address for an Order.
public class Customer
{
    private string _name;
    private Address _address;

    // Keep the customer's identity and address together for the Order methods.
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    // Order uses this method to choose the shipping fee; the Address checks the country.
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // Order.GetShippingLabel uses these methods to print the recipient and address.
    public string GetName()
    {
        return _name;
    }

    public string GetFullAddress()
    {
        return _address.GetFullAddress();
    }
}
