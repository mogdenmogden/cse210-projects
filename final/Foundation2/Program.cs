using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");
        Console.Clear();
        string edgeLine = new string('-',25);
        Console.WriteLine($"\n{edgeLine}\n");
        Product productA = new Product("box\t\t","item #bx983",4,8.95);
        Product productB = new Product("soup bowl set (8pcs)","item #sb34",1,25.50);
        Product productC = new Product("cup set (8pcs)\t","item #cs022",1,32.60);
        Product productD = new Product("plate set (8pcs)","item #ps385",1,25.50);
        Product productE = new Product("mixing bowl\t","item #mb951",1,18.95);

        Address addressMrLooper = new Address("123 Sesame Street","Manhattan","NY","USA");
        Customer customer1 = new Customer("Mister Looper",addressMrLooper);
        Order orderMrLooper = new Order(customer1);
        orderMrLooper.AddProductToOrder(productA);
        orderMrLooper.AddProductToOrder(productB);
        orderMrLooper.AddProductToOrder(productE);

        Address addressJaneSmith = new Address("345 Your Blvd","Anytown","KS","USA");
        Customer customer2 = new Customer("Jane Smith",addressJaneSmith);
        Order orderJaneSmith = new Order(customer2);
        orderJaneSmith.AddProductToOrder(productA);
        orderJaneSmith.AddProductToOrder(productB);
        orderJaneSmith.AddProductToOrder(productC);
        orderJaneSmith.AddProductToOrder(productD);

        Address addressJoseCosta = new Address("18 Avenida A, Apt#7","Recife","Pernambuco","Brazil");
        Customer customer3 = new Customer("Jose Melo de Costa",addressJoseCosta);
        Order orderJoseCosta = new Order(customer3);
        orderJoseCosta.AddProductToOrder(productE);
        orderJoseCosta.AddProductToOrder(productD);
        orderJoseCosta.AddProductToOrder(productC);
        orderJoseCosta.AddProductToOrder(productB);
        orderJoseCosta.AddProductToOrder(productA);

        orderMrLooper.PrintShipLabel();
        orderMrLooper.PrintPackLabel();
        orderMrLooper.GetProductInvoiceTotal();

        orderJaneSmith.PrintShipLabel();
        orderJaneSmith.PrintPackLabel();
        orderJaneSmith.GetProductInvoiceTotal();

        orderJoseCosta.PrintShipLabel();
        orderJoseCosta.PrintPackLabel();
        orderJoseCosta.GetProductInvoiceTotal();
        Console.WriteLine($"\n{edgeLine}\n");
    }
}