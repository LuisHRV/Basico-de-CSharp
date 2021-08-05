using System;

namespace Minhas_ideias_parte_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome, sua idade, seu sexo e sua altura.");

            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            int idade = int.Parse(vet[1]);
            char sexo = char.Parse(vet[2]);
            double altura = double.Parse(vet[3]);

            Console.Write("Nome do Participante: ");
            Console.WriteLine(nome);
            Console.Write("Idade do participante: ");
            Console.WriteLine(idade);
            Console.Write("Sexo do Participante: ");
            Console.WriteLine(sexo);
            Console.Write("Altura do Participante: ");
            Console.WriteLine(altura);

            Console.ReadLine();
        }
    }
}
