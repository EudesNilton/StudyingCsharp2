using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyingCsharp2.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho)
        {
            try
            {
                string[] linhas = File.ReadAllLines(caminho);

                //retornar pra quem chamou o arquivo
                return (true, linhas, linhas.Count());
            } catch(Exception ex)
            {
                return (false, new string[0], 0);
            }
            


        }
    }
}