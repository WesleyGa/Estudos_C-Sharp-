using System;
using Microsoft.VisualBasic;

namespace MeuApp
{
    class Program

    {
        static void Main(string[] args)

        {
            // No lugar do 'Product' poderia ser o 'var'.
            var mouse = new Product(1, "Mouse Gamer", 299.7, EProductType.Product);
            var manutencaoEletrica = new Product(2, "Manutenção elétrica residencial", 500, EProductType.Service);


            //Sobrescrever ou caso tenha iniciado sem valor.
            mouse.Id = 22;



            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.PriceInDolar(6));
            Console.WriteLine(mouse.Type);
            Console.WriteLine((int)mouse.Type);
            Console.WriteLine(manutencaoEletrica.Type);
        }
    }

    struct Product
    {
        // Método construtor. Não retorna nada
        public Product(int id, string name, double price, EProductType type)
        {
            Id = id;
            Name = name;
            Price = price;
            Type = type;

        }

        public int Id;
        public string Name;
        public double Price;
        public EProductType Type;


        public double PriceInDolar(double dolar)
        {
            return Price * dolar;
        }
    }

    enum EProductType
    {
        Product = 1,
        Service = 2,
    }
}
