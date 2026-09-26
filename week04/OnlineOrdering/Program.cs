using System;
using System.Collections.Concurrent;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        
        Product product = new Product();
        product.setProduct(1, "Laptop", 999.99, 10);
        product.setProduct(2, "Smartphone", 499.99, 20);
        product.getProduct();

        Customer customer = new Customer();
        customer.setCustomer("John Doe");
        customer.setCustomer("Michael Smith");
        

        Address address = new Address();
        address.setAddress("John Doe", new List<string> { "123 Main St", "New York", "USA" });
        address.setAddress("Michael Smith", new List<string> { "456 Elm St", "Los Angeles", "USA" });
        address.getAddress();

        foreach (var name in customer.getCustomers())
        {
            foreach (var kvp in address.getAddress())
            {
                if (kvp.Key == name)
                {
                    Console.WriteLine($"Customer: {name}, Address: {string.Join(", ", kvp.Value)}");
                    List<string> fullAddress = kvp.Value;
                    string country = fullAddress[2];
                    if ( address.countryCheck(country) == true)
                    {
                        Console.WriteLine("Low Cost");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("High Cost");  
                        Console.WriteLine();
                    }
                   
                }
            }
        }

        Order order = new Order();
        Dictionary<string, List<string>> allproducts = product.getProduct();
        order.setOrder("John Doe", allproducts);

    }
}


public class Product
{
    Dictionary<string, List<string>> _products = new Dictionary<string, List<string>>();
    private int _id;
    private string _product;
    private double _price;
    private int _quantity;

    public void setProduct(int id, string product, double price, int quantity)
    {
        _id = id;
        _product = product;
        _price = price;
        _quantity = quantity;

        List<string> productDetails = new List<string>();
        productDetails.Add(_product);
        productDetails.Add(_price.ToString());
        productDetails.Add(_quantity.ToString());

        _products.Add(_id.ToString(), productDetails);
    }

    public Dictionary<string, List<string>> getProduct()
    {
        return _products;
    }
}

public class Customer
{
    List<string> _customers = new List<string>();
    private string _name;

    public void setCustomer(string name)
    {
        _name = name;
        _customers.Add(_name);
    }
    public List<string> getCustomers()
    {
        return _customers;
    }

}

public class Address
{
    private Dictionary<string, List<string>> _customersAddress = new Dictionary<string, List<string>>();
    private string _street;
    private string _city;
    private string _country;

    public void setAddress(string name, List<string> address)
    {
        _street = address[0];
        _city = address[1];
        _country = address[2];
        _customersAddress.Add(name, new List<string> {_street, _city, _country });
    }

    public Dictionary<string, List<string>> getAddress()
    {
        return _customersAddress;
    }

    public bool countryCheck(string country)
    {
        if (country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

public class Order
{
    private string _Customer;
    private Dictionary<string, Dictionary<string, List<string>>> _allProducts = new Dictionary<string, Dictionary<string, List<string>>>();

    public void setOrder(string name, Dictionary<string, List<string>> products)
    {
        _Customer = name;
        _allProducts.Add(_Customer, products);
    }

    public double totalCost(double price, int quantity)
    {
        double totalCost = price * quantity;
        return totalCost;
    }
}
