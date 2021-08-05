using System;

namespace Exercicios_de_matematica_parte_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double cump = 10.0;
            double alt = 30.0;
            double ppmq = 200.0;

            double area = cump * alt;
            Console.WriteLine(area);

            double preço = area * ppmq;
            Console.WriteLine("R$ " +  preço);
        }
    }
}
