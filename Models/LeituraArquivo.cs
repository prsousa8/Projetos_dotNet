using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projetos_dotNet.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] linhas, int QuantidadeLinhas) LerArquivo(string caminho){
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true,linhas,linhas.Count());
            }
            catch (Exception ex)
            {
                
                return (false,new string[0],0);
            }
            
        }
    }
}