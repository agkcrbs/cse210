using System;

class Program
{
    static void Main(string[] arguments)
    {
        // Console.WriteLine("Hello Foundation2 World!");
        Order order1 = new Order("Jutaek Han", "Kia Apartments #601", "Jeonju", "Jeonlabukdo", "R.O.K.");
        Product productOrder1 = new Product("Wi-Fi mouse adapter", "C073", 9.98, 1);
        Product productOrder2 = new Product("laptop battery", "C120", 19.96, 1);
        Product productOrder3 = new Product("USB mouse", "C031", 4.99, 2);
        order1.AddToProductList(productOrder1);
        order1.AddToProductList(productOrder2);
        order1.AddToProductList(productOrder3);

        Order order2 = new Order("Frita Dorita", "3397 E. Fried Goods Way", "Holladay", "UT", "U.S.A.");
        Product productOrder4 = new Product("mixed nuts", "F244", 12.50, 1);
        Product productOrder5 = new Product("dried mangos 1 lb.", "F316", 6.99, 2);
        Product productOrder6 = new Product("Cara Cara oranges 1 lb.", "F092", 0.99, 16);
        order2.AddToProductList(productOrder4);
        order2.AddToProductList(productOrder5);
        order2.AddToProductList(productOrder6);

        Order order3 = new Order("Boyd O'Neal", "1200 S. Main Street", "Rexburg", "ID", "U.S.A.");
        Product productOrder7 = new Product("packing tape", "H441", 3.97, 1);
        Product productOrder8 = new Product("toothbrush", "H308", 0.99, 5);
        Product productOrder9 = new Product("toilet tissues 2 ply 12 ct.", "H275", 7.97, 3);
        order3.AddToProductList(productOrder7);
        order3.AddToProductList(productOrder8);
        order3.AddToProductList(productOrder9);

        Console.WriteLine("\nLabels:");

        Console.WriteLine("------\n[Order #1]");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetTotalPrice());
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine("------\n[Order #2]");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetTotalPrice());
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine("------\n[Order #3]");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine(order3.GetTotalPrice());
        Console.WriteLine(order3.GetShippingLabel());
    }
}
