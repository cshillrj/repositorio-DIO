using System;
using System.Collections.Generic;
using Estudo01;
using Estudo01.Helper;
using Estudo01.Interfaces;

namespace Estudo01
{
    public class Program
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\MEUS ARQUIVOS\\repositorio-DIO\\Estudos-Csharp\\Estudo01";
            var caminhoPathCombine = Path.Combine(caminho, "Estudo01");
            var criarArquivo = Path.Combine(caminho, "ArquivoTeste.txt");
            var caminhoArquivo = Path.Combine(caminho, "ArquivoTesteStream.txt");
            var NovoCaminhoArquivo = Path.Combine(caminho, "Helper", "ArquivoTesteStream.txt");

            var listaStream = new List<string> {"Linha1", "Linha2", "Linha3", "Linha4"};
            var listaStreamContinua = new List<string> {"Linha5", "Linha6", "Linha7", "Linha8"};
            

            FileHelper helper = new FileHelper();
            //helper.ListarDiretorios(caminho);
            //helper.ListarArquivosDiretorio(caminho);
            //helper.CriarArquivoTexto(criarArquivo, "Hello World!");
            //helper.CriarArquivoTextoStream(caminhoArquivo, listaStream);
            //helper.AdicionarTextoStream(caminhoArquivo, listaStreamContinua);
            //helper.MoverArquivo(caminhoArquivo, NovoCaminhoArquivo);
            //helper.CopiarArquivo(NovoCaminhoArquivo, caminhoArquivo);
            helper.DeletarArquivo(NovoCaminhoArquivo);



            /*ICalculadora calc = new Calculadora();
            System.Console.WriteLine($"O valor da soma é {calc.Somar(10, 20)}.");
             System.Console.WriteLine($"O valor da divisão é {calc.Dividir(27, 3)}.");
              System.Console.WriteLine($"O valor da multiplicação é {calc.Multiplicar(25, 7)}.");
               System.Console.WriteLine($"O valor da subtração é {calc.Subtrair(35, 10)}.");

            Computador comp01 = new Computador();
            System.Console.WriteLine(comp01.ToString());

            Corrente conta = new Corrente();
            conta.Creditar(100);
            conta.ExibirSaldo();


            Calculadora calc1 = new Calculadora();
            //calc1.Somar(10, 10);

            System.Console.WriteLine($"A soma dos valores é {calc1.Somar(10, 10)}");
            System.Console.WriteLine($"A segunda soma dos valores é {calc1.Somar(10, 10, 15)}");

            
            // Valores válidos
            Retangulo r = new Retangulo();
            r.DefinirMedidas(30, 30);

            System.Console.WriteLine($"Área do Retângulo: {r.ObterArea()}m2");

            // Valores inválidos
            Retangulo r2= new Retangulo();
            r2.DefinirMedidas(0, 0);

            System.Console.WriteLine($"Área do Retângulo: {r2.ObterArea()}m2");


            Aluno aluno1 = new Aluno();

            aluno1.Nome = "Hill";
            aluno1.Idade = 44;
            aluno1.Nota = 10;
            aluno1.Apresentar();

            Professor prof1 = new Professor();

            prof1.Nome = "Hill";
            prof1.Idade = 44;
            prof1.Salario = 10;
            prof1.Apresentar();

            Diretor dir1 = new Diretor();

            dir1.Nome = "Pedro";
            dir1.Idade = 44;
            dir1.Apresentar();*/
        }
    }
}