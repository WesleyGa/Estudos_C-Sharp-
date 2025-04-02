using System;


namespace MeuApp
{
    class Program

    {
        static void Main(string[] args)

        {

            var id = Guid.NewGuid(); //Cria um identificador global único.
            id.ToString(); // Converte para o tipo string.

            // id = new Guid(""); Erro.
            id = new Guid("64b57f3e-76e8-4a6c-a969-0377433263f6"); // Aceita normalmente.

            Console.WriteLine(id.ToString().Substring(0, 8)); // Pega os 8 primeiros caracteres.

            if (id == Guid.NewGuid())
            { // Apenas para entender que é possivel comparar um id com outro.
                Console.WriteLine("Esse id ja existe"); // Quase impossível de acontecer.
            }

        }
    }
}