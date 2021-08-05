using System;
using System.Globalization;

namespace Condições
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que horas são?");

            double horas = double.Parse(Console.ReadLine());



            if (horas < 12.00)
            {
                Console.WriteLine("Bom Dia !");
            }
            else
            {
                if (horas <= 18.00)
                    Console.WriteLine("Boa tarde !");

                else
                {
                    if (horas > 18.00)
                    {
                        Console.WriteLine("Boa Noite !");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
