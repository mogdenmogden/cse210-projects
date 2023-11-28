public class Product
{
    private string _productName, _productId;
    private double _unitPrice, _productPrice;
    private int _productQuantity;

    public Product(string name, string id, int qty, double unitPrice )
    {
        _productPrice = qty*unitPrice;
        _productName = name;
        _productId = id;
        _unitPrice = unitPrice;
        _productQuantity = qty;
    }

    public double GetProductPrice()
    {
        return _productPrice;
    }

    public string GetProductLabelLine()
    {
        return $"{_productId}\t{_productName}\t${_unitPrice.ToString("N2")}/ea\t{_productQuantity}\t${_productPrice.ToString("N2")}\n";
    }
}