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