using System;

namespace MeuApp
{
    class Program

    {
        static void Main(string[] args)

        {
            // No lugar do 'Product' poderia ser o 'var'.
            Product mouse = new Product(1, "Mouse Gamer", 299.7);

            //Sobrescrever ou caso tenha iniciado sem valor.
            mouse.Id = 22;

            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
        }
    }

    struct Product
    {
        // Método construtor. Não retorna nada
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
