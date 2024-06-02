public class Order
{
    private List<Product> _products = new List<Product>();

    public void AddItem(Product product)
    {
        _products.Add(product);
    }

    private double Subtotal()
    {
        double subtotal = 0;
        foreach (Product p in _products)
        {
            subtotal += (p.GetPrice() * p.GetQuantity());
        }
        return subtotal;
    }

    private double ShippingCost(Address address)
    {
        double shipping;
        if (address.GetCountry() == "USA")
        {
            shipping = 5;
        }
        else
        {
            shipping = 35;
        }
        return shipping;
    }

    private double TotalCost(Address address)
    {
        double subtotal = Subtotal();
        double shipping = ShippingCost(address);
        return subtotal + shipping;
    }

    public void AllCosts(Address address)
    {
        Console.WriteLine($"Subtotal: ${Math.Round(Subtotal(), 2)}");
        Console.WriteLine($"Shipping: ${Math.Round(ShippingCost(address), 2)}");
        Console.WriteLine($"Total: ${Math.Round(TotalCost(address), 2)}");
    }

    public void PrintTotalCost(Address address)
    {
        Console.WriteLine($"Total: ${Math.Round(TotalCost(address), 2)}");
    }

    public void PrintPackingLabel()
    {
        Console.WriteLine("Packing Label: ");
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.GetId()} | {product.GetName()}");
        }
        Console.WriteLine();
    }

    public void PrintShippingLabel(Address address, Customer customer)
    {
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine(address.GetShippingInfo(customer));
    }
}