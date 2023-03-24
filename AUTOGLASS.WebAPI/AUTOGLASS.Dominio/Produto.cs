using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AUTOGLASS.Dominio
{
    public class Produto
    {
        public int? Id { get; set; }
        public string DescricaoProduto { get; set; }
        public bool SituacaoProduto { get; set; }
        public DateTime DataFabricacao { get; set; }
        public DateTime DataValidade { get; set; }
        //public Fornecedor Fornecedores { get; set; }
        
    }
}
