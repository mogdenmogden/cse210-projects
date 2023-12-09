public class Order
{
    private Customer _customer;
    private List<Product> _products = new List<Product>();
    private double _totalCost, _shippingCost;
    private string _packLabel, _shipLabel;

    public Order(Customer customer)
    {
        _customer = customer;
        _packLabel = "\nOrder Invoice (Pack Label)\n";
        
        if (customer.IsUSA() == true)
        {
            _shippingCost = 5.00;
        }
        else
        {
            _shippingCost =  35.00;
        }    
        _totalCost = _shippingCost;
        _shipLabel = customer.GetShipInfo();
        
    }

    public void AddProductToOrder(Product product)
    {
        _products.Add(product);
        _totalCost = _totalCost + product.GetProductPrice();  //total cost of order
        _packLabel = string.Concat(_packLabel,product.GetProductLabelLine());
    }

    public string PrintShipLabel()
    {
        // Console.WriteLine(_shipLabel);//prefer to do it this way
        return _shipLabel;  //I thought it was easier to just return void and writeline the label. The spec said "can return a string for the shipping label". So I did this.
    }

    public string PrintPackLabel()  //I thought it was easier to just return void and writeline the label. The spec said "can return a string for the packing label". So I did this.
    {
        // Console.WriteLine(_packLabel);  //prefer to do it this way
        // Console.WriteLine($"Shipping Cost:\t\t\t\t\t\t\t${_shippingCost.ToString("N2")}");  //prefer to do it this way
        return $"{_packLabel}\nShipping Cost:\t\t\t\t\t\t\t${_shippingCost.ToString("N2")}"; 
    }

    public void GetProductInvoiceTotal()  //total cost of order
    {
        string divider = new string('=',20);
        Console.WriteLine($"Your Order Total is:\t\t\t\t\t\t${_totalCost.ToString("N2")}");
        Console.WriteLine($"{divider}\n\n");
    }
}