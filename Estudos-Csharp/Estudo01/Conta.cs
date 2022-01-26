using System;
using System.Collections.Generic;
using Estudo01;

namespace Estudo01
{
    // Classes abstratas e métodos abstratos.
    public abstract class Conta
    {
        protected double Saldo;

        public abstract void Creditar(double Valor);

        public void ExibirSaldo()
        {
            System.Console.WriteLine($"Seu saldo atual é de R$ {Saldo}");
        }

    }

}