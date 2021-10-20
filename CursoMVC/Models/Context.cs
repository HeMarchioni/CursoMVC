using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CursoMVC.Models
{


    public class Context : DbContext
    {

        public DbSet<Categoria> Categorias { get; set; }   // -> Falar que ira ser criado a tabela (categoria)
 


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Cursomvc;Integrated Security=True"); 

        }

    }
}
