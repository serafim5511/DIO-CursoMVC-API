using CursoMVC.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;

namespace CursoTeste
{
    class CategoriasControllerTest
    {
        private readonly Mock<DbSet<Categoria>> _mokSet;
        private readonly Mock<DbSet<Context>> _mokContext;
        private readonly Categoria _mokCategoria;
        public  CategoriasControllerTest ()
            { 

            }
    }
}
