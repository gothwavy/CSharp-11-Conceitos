using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Heranca
{
    internal class Pessoa
    {

        // Atributos
        protected string? Nome;
        protected int Idade;

        // Metodo para apresentar os dados
        protected void ApresentarPessoa()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
        }

    }
}
