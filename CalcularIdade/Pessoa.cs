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

        //Vamos melhorar isso arqui
        
        private int idade;
        public int Idade
        {
            get { 
                this.CalcularIdade();
                return this.idade; 
                }
        }
        
        public void ExibirDados()

        {
            Console.WriteLine("Nome: " +this.Nome);
            Console.WriteLine("Ano de Nascimento: " +this.AnoNascimento);
            this.CalcularIdade();
            Console.WriteLine("Idade: " +this.Idade);           
        }

        private void CalcularIdade()
        {
            DateTime data = DateTime.Now;
            int ano = data.Year;
            this.idade = ano - this.AnoNascimento;
        }
    }
}