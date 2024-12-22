using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Heranca
{
    internal class Colaborador : Pessoa
    {

        // Atributos
        private string? _cargo;
        private double _salario;

        // Construtor
        public Colaborador(string nome, int idade, string cargo, double salario)
        {

            Nome = nome;
            Idade = idade;
            _cargo = cargo;
            _salario = salario;

            ApresentarPessoa();
            ApresentarColaborador();

        }

        // Metodo para apresentar dados
        private void ApresentarColaborador()
        {
            Console.WriteLine($"Cargo: {_cargo}");
            Console.WriteLine($"Salario: {_salario}");
        }

    }
}
