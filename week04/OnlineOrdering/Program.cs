using System;
using System.Collections.Concurrent;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        
        Product product = new Product();
        product.setProduct(1, "Laptop", 850.99, 10);
        product.setProduct(2, "Smartphone", 400.99, 20);


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
                int shipCost = 0;
                if (kvp.Key == name)
                {
                    /*Console.WriteLine($"Customer: {name}, Address: {string.Join(", ", kvp.Value)}");*/
                    List<string> fullAddress = kvp.Value;
                    string country = fullAddress[2];
                    if ( address.countryCheck(country) == true)
                    {
                        shipCost = 5;
                        Console.WriteLine($"The shipping cost for {name} is ${shipCost}UDS");

                    }
                    else
                    {
                        shipCost = 35;
                        Console.WriteLine($"The shipping cost for {name} is ${shipCost}UDS");
                    }
                   
                }
            }
        }
        Console.WriteLine();
        Order order = new Order();
        List<string> clients = customer.getCustomers();

        Dictionary<string, List<string>> allProducts = product.getProduct();
        int counting = 0;
        foreach(var key in allProducts)
        {
            string client = clients[counting];

            List<string> allItems = key.Value;
            string item1 = allItems[0];
            string item2 = allItems[1];
            string item3 = allItems[2];
            counting++;
            order.setOrder(client, allItems);
        }
        order.getOrder();

        List<string> allProductList = new List<string>();

        /*for (int i = 0; i < clients.Count; i++)
        {
            string client = clients[i];
            Console.WriteLine(client);
            foreach (var key in allProducts)
            {
                Console.WriteLine(key.Key);
            }
            foreach (var productEntry in allProducts)
            {
                Console.WriteLine(productEntry.Key);
                allProductList = productEntry.Value;
                for (int it = 0; it < allProductList.Count; it++)
                {
                    Console.WriteLine(allProductList[it]);
                }
            }
            
            
            
        }*/
        

        

        
        

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
    private Dictionary<string, List<string>> _order = new Dictionary<string, List<string>>();

    public void setOrder(string name, List<string> products)
    {
        _Customer = name;
        _order.Add(_Customer, products);
    }

    public void getOrder()
    {
        for (int i = 0; i < 1; i++)
        {
            foreach (var key in _order.Keys)
            {
                List<string> itemList = _order[key];
                string item = itemList[0];
                string price1 = itemList[1];
                string quantity1 = itemList[2];
                double price = double.Parse(price1);
                double quantity = double.Parse(quantity1);
                double total = price*quantity;
                Console.WriteLine($"Customer: {key} bought {item}, {price1}, {quantity1}, with a total of ${total}USD");
            }
            
            /*foreach (var key in _order)
            {
                List<string> itemList = key.Value;
                string id = itemList[0];
                string product = itemList[1];
                string price = itemList[2];
                Console.WriteLine($"{id}, {product}, {price}");
            }*/
        }
    }

    public int getShipping(int shipCost)
    {
        return shipCost;
    }

    public double totalCost(double price, int quantity)
    {
        double totalCost = price * quantity;
        return totalCost;
    }
}
