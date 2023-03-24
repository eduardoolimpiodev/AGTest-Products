using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AUTOGLASS.WebAPI.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string DescricaoFornecedor { get; set; }
        public string CNPJ { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
