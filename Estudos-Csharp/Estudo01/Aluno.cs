using System;
using System.Collections.Generic;
using Estudo01;

namespace Estudo01
{
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e sou um aluno nota {Nota}.");

        }

    }

}