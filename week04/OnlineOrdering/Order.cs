using System.Collections.Generic;

// An Order brings a Customer and a product list together to calculate costs and build labels.
public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // The stored customer supplies the shipping address and determines the shipping fee.
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Main uses this method to add products that the calculation and label methods process.
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Sum each product's cost, then add one shipping fee based on the customer's address.
    public double CalculateTotalCost()
    {
        double total = 0;

        foreach (Product product in _products)
        {
            total += product.CalculateTotalPrice();
        }

        if (_customer.IsInUSA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    // Use Product getters to list the name and ID of every product in this order.
    public string GetPackingLabel()
    {
        string label = "Packing Label:" + Environment.NewLine;

        foreach (Product product in _products)
        {
            label += $"{product.GetProductName()} (ID: {product.GetProductId()})"
                + Environment.NewLine;
        }

        return label;
    }

    // Use Customer methods to combine the recipient's name and formatted Address.
    public string GetShippingLabel()
    {
        return "Shipping Label:" + Environment.NewLine
            + _customer.GetName() + Environment.NewLine
            + _customer.GetFullAddress();
    }
}
