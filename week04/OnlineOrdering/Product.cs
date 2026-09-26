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