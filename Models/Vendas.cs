using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json; //(*)

namespace Projetos_dotNet.Models
{
    public class Vendas
    {
        public int Id { get; set; }
        [JsonProperty("Nome_Produto")] //Caso as propriedades(atributo) do json estejam com nome diferente(*)
        public string Produto { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataVenda { get; set; }
        public Vendas(int id, string produto, decimal preco,DateTime data){
            Id = id;
            Produto = produto;
            Preco = preco;
            DataVenda = data;
        }
    }

    
}