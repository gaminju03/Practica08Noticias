using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Practica08Noticias.Models;

namespace Practica08Noticias.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

           
        }
        public DbSet <Categoria> Categorias { get; set; }
        public DbSet <Noticia> Noticias { get; set; }//
    }
}
