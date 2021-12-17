using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdicionandoArray
{
    internal class Pessoa
    {
        string nome { get; set; }
        int idade { get; set; }
        double peso { get; set; }

        public void cadastrarPessoa()
        {
            Console.Write("Informe o Nome da Pessoa: ");
            nome = Console.ReadLine();

            Console.Write("Informe a Idade da Pessoa: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Informe o Peso da Pessoa: ");
            peso = double.Parse(Console.ReadLine());
        }

        public void exibirPessoa()
        {
            Console.WriteLine($"Nome da Pessoa: {nome}" +
                $"\nIdade {idade}" +
                $"\nPeso: {peso}");
        }
    }
}
