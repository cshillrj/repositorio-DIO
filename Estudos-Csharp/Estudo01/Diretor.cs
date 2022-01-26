using System;
using System.Collections.Generic;
using Estudo01;

namespace Estudo01
{
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine($"Olá, Sou o DIRETOR {Nome}, responsável pela escola.");

        }

    }

}