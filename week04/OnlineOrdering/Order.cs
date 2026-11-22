using System.Collections.Generic;
using System.ComponentModel;

public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double total = 0;

        foreach(Product product in _products)
        {
            total += product.CalculateTotalPrice();
        }

        if(_customer.IsInUSA() == true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GetPackingLabel()
    {
    string label = "Packing Label:" + Environment.NewLine;

    foreach (Product product in _products)
    {
        label  += $"{product.GetProductName()} (ID: {product.GetProductId()})"
        + Environment.NewLine;
    }

    return label;
    }

    public string GetShippingLabel()
    {
        return "Shipping Label:" + Environment.NewLine
            + _customer.GetName() + Environment.NewLine
            + _customer.GetFullAddress();
    }
}