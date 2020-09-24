using System;

namespace jurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            double capital;
            double taxa;
            double resultTaxa;
            double tempo;
            double juros;
            double montante;

            Console.WriteLine("digite seu valor r$:");
            capital = double.Parse(Console.ReadLine());

            Console.WriteLine("digite sua taxa de juros %:");
            taxa =  double.Parse(Console.ReadLine());

            Console.WriteLine("digite seu tempo de parcelas:");
            tempo = double.Parse(Console.ReadLine());
            Console.Write("/n");

            resultTaxa = taxa/ 100;
            juros =capital * resultTaxa *  tempo;
            Console.WriteLine($"seu juros é igual = {0}", juros);

            montante = capital + juros;
            Console.WriteLine("seu montante é = {0}", montante);
            Console.Write("\n");

            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();






        }
    }
}
