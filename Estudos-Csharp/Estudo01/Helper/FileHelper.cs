using System;
using System.Collections.Generic;
using Estudo01;
using Estudo01.Helper;
using Estudo01.Interfaces;


namespace Estudo01.Helper
{
    public class FileHelper
    {
       /* public void ListarDiretorios(string caminho)
        {
            var retornoCaminho = Directory.GetDirectories(caminho, "*", SearchOption.AllDirectories);

            foreach(var retorno in retornoCaminho)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void ListarArquivosDiretorio(string caminho)
        {
            var retornoArquivos = Directory.GetFiles(caminho);

            foreach(var retorno in retornoArquivos)
            {
                System.Console.WriteLine(retorno);
            }
        }

        public void CriarArquivoTexto(string caminho, string conteudo)
        {
            if(!File.Exists(caminho))
            {
                File.WriteAllText(caminho, conteudo);
            }

        }

        public void CriarArquivoTextoStream(string caminho, List<string> conteudo)
        {
            using(var stream = File.CreateText(caminho)) //O using libera o arquivo para que se trabalhe outro processo
            {

                foreach (var linha in conteudo)  // Pegar os dados da lista de string chamada conteúdo
                {
                    stream.WriteLine(linha);
                    
                }

            }

        }

        public void AdicionarTexto(string caminho, string conteudo)
        {
            File.AppendAllText(caminho, conteudo);
        }

         public void AdicionarTextoStream(string caminho, List<string> conteudo)
        {
            using(var stream = File.AppendText(caminho)) 
            {

                foreach (var linha in conteudo)  // Pegar os dados da lista de string chamada conteúdo
                {
                    stream.WriteLine(linha);
                    
                }

            }

        }*/

        public void MoverArquivo(string caminho, string novoCaminho)
        {
            File.Move(caminho, novoCaminho);
        }

        public void CopiarArquivo(string caminho, string novoCaminho)
        {
            File.Copy(caminho, novoCaminho);
        }

        public void DeletarArquivo(string caminho)
        {
            File.Delete(caminho);
        }

        
    }
}