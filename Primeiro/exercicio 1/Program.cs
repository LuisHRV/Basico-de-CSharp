using System;
using System.Globalization;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double N, i,t, soma;
            N = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            t = 10;
            for(i=1; i <= t; i++){
                soma = i * N;
                Console.WriteLine(i + " x "  + N+ " = "+ soma);
            }
        }
    }
}
