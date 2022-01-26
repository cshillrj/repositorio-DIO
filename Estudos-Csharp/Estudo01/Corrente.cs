using System;
using System.Collections.Generic;
using Estudo01;

namespace Estudo01
{
    public class Corrente : Conta
    {
        public override void Creditar(double Valor)
        {
            this.Saldo = Valor;
        }
    }

}