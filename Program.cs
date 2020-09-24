using System;

namespace jurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal capital;
            decimal taxa;
            decimal resultTaxa;
            decimal tempo;
            decimal juros;
            decimal montante;

            Console.WriteLine("digite seu valor r$:");
            capital = decimal.Parse(Console.ReadLine());

            Console.WriteLine("digite sua taxa de juros %:");
            taxa =  decimal.Parse(Console.ReadLine());

            Console.WriteLine("digite seu tempo de parcelas:");
            tempo = decimal.Parse(Console.ReadLine());
            Console.Write("/n");

            resultTaxa = taxa/ 100;
            juros =capital * resultTaxa *  tempo;
            Console.WriteLine("seu juros é igual = {0}", juros);

            montante = capital + juros;
            Console.WriteLine("seu montante é = {0}", montante);
            Console.Write(" \n ");

            Console.WriteLine("Pressione ENTER para sair!");
            Console.ReadKey();






        }
    }
}
