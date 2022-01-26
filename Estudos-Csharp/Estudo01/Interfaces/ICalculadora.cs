using System;
using System.Collections.Generic;
using Estudo01;

namespace Estudo01.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2);
        int Dividir(int num1, int num2)
        {
            return num1 / num2;  // Se implementar aqui, não precisa implementar na classe Calculadora.
        }

         
    }
}