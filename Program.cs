using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(101,"Alex");
            Customer c2 = new Customer(102, "Tom");
           // c1.describe();
           // c2.describe();

            //create two product pbjects
            Product p1 = new Product();
            p1.pid = 1;
            p1.product_name = "Apple";
            p1.price = 5.3;

            Product p2 = new Product();
            p2.pid = 3;
            p2.product_name = "Choc";
            p2.price = 2.1;

            //add them to the shoplist of c1
            c1.shopList.Add(p1);
            c1.shopList.Add(p2);
            c1.ShowCart();
        }
    }
}
