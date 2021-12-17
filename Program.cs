using System;
using System.Collections;

namespace AdicionandoArray
{
    class Program
    {
        static void Main(String[] args)
        {
            ArrayList lista = new ArrayList();

            string resposta;

            do
            {
                Console.Clear();
                Pessoa pessoa = new Pessoa();
                pessoa.cadastrarPessoa();
                lista.Add(pessoa);

                Console.Write("Deseja Cadastrar outra pessoa?");
                resposta = Console.ReadLine().ToUpper();

            }
            while (resposta == "S");

            foreach(Pessoa pessoa in lista)
            {
                pessoa.exibirPessoa();
            }

            Console.ReadKey();
        }
    }
}