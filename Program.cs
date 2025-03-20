using System;

namespace MeuApp;

class Program
{
    static void Main(string[] args)
    {
        float valor = 25.8F;
        int outro = 25;
        valor = outro; // Conversão implícita. Ao contrário não é possivel. Não da para ter um numero do tipo float em um do tipo int.
        Console.WriteLine(valor.GetType());
        ushort outro2 = 23;
        valor = outro2;
        Console.WriteLine(valor.GetType());

        double valor2 = 28.4; // Não é necessario inserir o D ja que por padrão todos os numeros com ponto flutuante são double.

        /*valor = valor2;               Double tem maior precisão (64 bits) do que o float (32 bits).  
                                        Ao converter de double para float, você pode perder precisão, já que o float não consegue armazenar 
                                        todos os valores possíveis de um double sem truncamento. */

        valor2 = valor;                /*No caso contrário, ou seja, convertendo de float para double, o C# permite a conversão implícita, 
                               já que o double tem maior capacidade de armazenamento e pode acomodar valores de float sem perda
                               de precisão: */
        Console.WriteLine(valor2.GetType());



        int inteiroA = 100;
        uint inteiroSemSinal = (uint)inteiroA; // Conversão explícita. Obs: se o numero for negativo vai dar erro.
        Console.WriteLine(inteiroSemSinal.GetType());
        double numero = (double)inteiroA;
        Console.WriteLine(numero.GetType());



        // Parse

        int inteiroB = int.Parse("100"); // No caso do parse, ele sempre espera uma cadeia de caracteres.
        double inteiroC = double.Parse("200");
        //Convert

        int inteiroD = Convert.ToInt32("100"); // O convert é de fato uma classe, um objeto. Permite a conversão para outro tipos tambem.
        double inteiroE = Convert.ToDouble("100");

        // Funções ou Métodos
        int resultado = 0;
        void MeuMetedo(int n1, int n2)
        {
            resultado = n1 + n2;
        }

        MeuMetedo(10, 10);
        Console.WriteLine(resultado);

        int idade = 0;
    }
}
