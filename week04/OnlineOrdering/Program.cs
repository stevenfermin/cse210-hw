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


    }
}
