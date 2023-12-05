public class Order
{
    private List<Product> _product = new List<Product>();
    private Customer _customer;
    public Order(List<Product> product, Customer customer)
    {
        _product = product;
        _customer = customer;
    }
    public double CalculateTotalOrderCost()
    {
        double total = 0;
        foreach (var product in _product)
            {
                total += product.GetPrice();
            }
        total += ShipCast();
        return total;
    }
    public double ShipCast()
    {
        double shippingCast = _customer.IsUSA() ? 5: 35;
        return shippingCast;
    }
    public string PackLabel()
    {
        string label = "Packing Label:\n";

        foreach (var product in _product)
        {
            label += $"{product.GetName()} (ID: {product.GetId()})";
        }

        return label;
    }
    public string ShipLabel()
    {
        return $"Name: {_customer.GetName()}\nAddress: {_customer.GetAddress().GetAddress()}";
    }
}
public class Product
{
    private string _name;
    private string _productId;
    private double _price;
    private double _quantity;
    public Product(string name, string productId, double price, double quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetId()
    {
        return _productId;
    }
    public double GetPrice()
    {
        return (double)_price * (double)_quantity;
    }
}
public class Customer 
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;        
    }
    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address;
    }
    public bool IsUSA()
    {
        return _address.IsUSA();
    }
}
public class Address
{
    private string _street; 
    private string _city; 
    private string _state;
    private string _country;
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool IsUSA()
    {
        return _country == "USA";
    }
    public string GetAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}