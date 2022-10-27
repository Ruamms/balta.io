using System;

namespace MeuApp
{
    class Program
    {
        static void Main(String[] args)
        {

        }
        struct Product
        {
            public Product(int id, string name, double price)
            {
                Id = id;
                Name = name;
                Price = price;
            }
            public int Id;
            public string Name;
            public double Price;

            public double PriceInDolar(double dolar)
            {
                return Price * dolar;
            }
        }
    }
}