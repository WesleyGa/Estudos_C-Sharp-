using System;
using System.Text;


namespace MeuApp
{
    class Program

    {
        static void Main(string[] args)

        {
            Console.Clear();
            // var data = new DateTime();

            var data = DateTime.Now; // Propriedade

            //var formatada = String.Format("{0:yyyy/MM/dd hh:mm:ss ff z}", data); //Exibi a atual hora e data formatada
            //var formatada = String.Format("{0:t}", data); //Apenas a hora. 't' ShortDateTime : '16:06'
            //var formatada = String.Format("{0:D}", data); // Por extenso: 'quinta-feira, 10 de abril de 2025'
            //var formatada = String.Format("{0:f}", data); //Combina a data com a hora. 'quinta-feira, 10 de abril de 2025 16:09'
            //var formatada = String.Format("{0:g}", data); //Combina tambem, mas, com tipo short. '10/04/2025 16:12'

            /*
            //Melhor forma de acrescentar data
            Console.WriteLine(data.AddDays(-12)); // É possível subtrair também.
            Console.WriteLine(data.AddYears(12));
            Console.WriteLine(data.AddDays(12));
            Console.WriteLine(data.AddSeconds(12));
            Console.WriteLine(data.AddMinutes(12)); */

            //Comparação
            if (data == DateTime.Now)  //Nunca será igual por causa dos milisegundos
                Console.WriteLine("É igual");

            if (data.Date == DateTime.Now.Date) // Dessa forma é possivel. Compara apenas a data
                Console.WriteLine("È igual");


        }
    }
}