using System;

namespace CalcularIdade
{
    public class Pessoa
    {
        private int anoNascimento;
        public int AnoNascimento
        {
            get { return this.anoNascimento; }
            set { this.anoNascimento = value; }
        }
        
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value.ToUpper(); }
        }
        
        public void ExibirDados()

        {
            Console.WriteLine("Nome: " +this.Nome);
            Console.WriteLine("Ano de Nascimento: " +this.AnoNascimento);
            int idade = this.CalcularIdade();
            Console.WriteLine("Idade: " +idade);           
        }

        private int CalcularIdade()
        {
            DateTime data = DateTime.Now;
            int ano = data.Year;
            int idade = ano - this.AnoNascimento;
            return idade;
        }
    }
}