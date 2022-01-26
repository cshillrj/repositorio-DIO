using System;
using System.Collections.Generic;
using Estudo01;

namespace Estudo01
{
    // Classes e métodos selados.
    public /*sealed*/ class Professor : Pessoa
    {
        public double Salario { get; set; }

        public /*sealed*/ override void Apresentar()
        {
            Console.WriteLine($"Olá, Sou o professor {Nome} e meu salário é de R${Salario} mil Reais.");

        }
    }

}