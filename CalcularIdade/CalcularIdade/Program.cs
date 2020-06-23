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
            Pessoa pessoa = new Pessoa();
            Console.Write("Nome da pessoa: ");
            pessoa.Nome = Console.ReadLine();
            Console.Write("Ano de nascimento: ");
            pessoa.AnoNascimento =Convert.ToInt32( Console.ReadLine());
            pessoa.ExibirDados();
            
            Console.ReadKey();
        }
    }
}
