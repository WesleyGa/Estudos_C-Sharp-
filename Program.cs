using System;
using System.Text;


namespace MeuApp
{
    class Program

    {
        static void Main(string[] args)

        {
            var texto = new StringBuilder(); // Obs: 'StringBuilder()' é do tipo 'StringBuilder' e não do tipo String. 
            texto.Append("Este texto ");
            texto.Append("é um texto ");
            texto.Append("de teste.");
            texto.Append(" Apenas ");
            texto.Append("isso");
            Console.WriteLine(texto);
        }
    }
}