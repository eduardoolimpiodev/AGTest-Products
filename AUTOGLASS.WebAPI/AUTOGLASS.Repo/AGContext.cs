using AUTOGLASS.Dominio;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AUTOGLASS.Repo
{
    public class AGContext : DbContext
    {
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet <Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=EDUARDOOLIMPIO;Database=AGApp;Trusted_Connection=True;");
        }
    }
}
