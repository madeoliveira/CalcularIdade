using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa que calcula Idade");
            Console.Write("Nome da pessoa: ");
             String nome = Console.ReadLine();
            Console.Write("Ano de nascimento: ");
            int ano = Convert.ToInt32(Console.ReadLine());
            Pessoa pessoa;
            pessoa = new Pessoa(nome, ano);
            pessoa.ExibirDados();

            Console.ReadKey();
        }
    }
}
