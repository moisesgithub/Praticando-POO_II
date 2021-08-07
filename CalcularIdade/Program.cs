using System;

namespace CalcularIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando a idade de uma pessoa! ");
            Pessoa p = new Pessoa();
            Console.Write("Nome da pessoa: ");
            p.Nome = Console.ReadLine();
            Console.Write("Ano de nascimento: ");
            p.AnoNascimento = Convert.ToInt32(Console.ReadLine());
            p.ExibirDados();

            Console.ReadKey();
        }
    }
}
