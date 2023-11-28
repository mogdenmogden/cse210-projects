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
        
        if (customer.GetCustomerCountry() == "USA")
        {
            _shippingCost = 5.00;
        }
        else
        {
            _shippingCost =  35.00;
        }    
        _totalCost = _shippingCost;
        _shipLabel = customer.GetShipLabel();
        
    }

    public void AddProductToOrder(Product product)
    {
        _products.Add(product);
        _totalCost = _totalCost + product.GetProductPrice();
        _packLabel = string.Concat(_packLabel,product.GetProductLabelLine());
    }

    public void PrintShipLabel()
    {
        Console.WriteLine(_shipLabel);
    }

    public void PrintPackLabel()
    {
        Console.WriteLine(_packLabel);
        Console.WriteLine($"Shipping Cost:\t\t\t\t\t\t\t${_shippingCost.ToString("N2")}");
    }

    public void GetProductInvoiceTotal()
    {
        string divider = new string('=',20);
        Console.WriteLine($"Your Order Total is:\t\t\t\t\t\t${_totalCost.ToString("N2")}");
        Console.WriteLine($"{divider}\n\n");
    }
}