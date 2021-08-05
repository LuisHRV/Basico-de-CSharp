using System;
using System.Globalization;

namespace Quinto
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            int y = int.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            string[] vet = Console.ReadLine().Split(' ');
            x = vet[0];
            y = int.Parse(vet[1]);
            z = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z.ToString("F2", CultureInfo.InvariantCulture));
            
            Console.ReadLine();
        }
    }
}
