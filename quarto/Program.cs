using static System.Console;

namespace quarto
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = ReadLine();
            string[] v = s.Split(' ');
            string a = v[0];
            string b = v[1];
            string c = v[2];

            WriteLine();

            WriteLine("Vôce adicionou a sua lsta de compras:");
            WriteLine(a);
            WriteLine(b);
            WriteLine(c);

            ReadLine();

        }
    }
}
