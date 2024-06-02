using System;

class Program
{
    static void Main(string[] args)
    {
        Product prod1 = new Product("Pants", "1234", 25.99, 4);
        Product prod2 = new Product("Shirt", "5678", 12.99, 2);
        Product prod3 = new Product("Shoes", "2583", 49.99, 1);

        Order order1 = new Order();
        Address address1 = new Address("1313 Disneyland Dr", "Anaheim", "CA", "USA");
        Customer cust1 = new Customer("Claire Winters", address1);
        order1.AddItem(prod3);
        order1.AddItem(prod2);

        order1.PrintTotalCost(address1);
        order1.PrintPackingLabel();
        order1.PrintShippingLabel(address1, cust1);
        Console.WriteLine();

        Order order2 = new Order();
        Address address2 = new Address("Boulevard du Parc", "Serris", "Paris", "France");
        Customer cust2 = new Customer("Louis Clarke", address2);
        order2.AddItem(prod3);
        order2.AddItem(prod1);
        order2.AddItem(prod2);

        order2.PrintTotalCost(address2);
        order2.PrintPackingLabel();
        order2.PrintShippingLabel(address2, cust2);
    }
}