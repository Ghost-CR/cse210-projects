// A Product stores the information used to calculate its cost and identify it on a label.
public class Product
{
    private string _productName;
    private int _productId;
    private double _price;
    private int _quantity;

    // Store the product data used by CalculateTotalPrice and the Order label methods.
    public Product(string name, int id, double price, int quantity)
    {
        _productName = name;
        _productId = id;
        _price = price;
        _quantity = quantity;
    }

    // Order.CalculateTotalCost uses this product-level calculation for every item in the order.
    public double CalculateTotalPrice()
    {
        return _price * _quantity;
    }

    // Order.GetPackingLabel uses these getters to list each product's name and ID.
    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductId()
    {
        return _productId;
    }
}
