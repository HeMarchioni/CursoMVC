using CursoAPI.Controllers;
using CursoMVC.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CursoTest
{
    public class CategoriasControllerTest
    {

        private readonly Mock<DbSet<Categoria>> mockSet;
        private readonly Mock<Context> mockContext;
        private readonly Categoria categoria;


        public CategoriasControllerTest()
        {

            mockSet = new Mock<DbSet<Categoria>>();
            mockContext = new Mock<Context>();
            categoria = new Categoria { Id = 1, Descricao = "Teste Categoria" };
        
        }

        [Fact]
        public async Task Get_Categoria()
        {
            var service = new CategoriasController(mockContext.Object); // -> instancio o controller que vou usar (passo o context)

            await service.GetCategoria(1);  //- > agora tenho acesso a seus metodos 

            mockSet.Verify(m => m.FindAsync(1), Times.Once());

        }


    }
}
