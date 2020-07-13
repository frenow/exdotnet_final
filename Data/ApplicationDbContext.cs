using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjetoDotNet2.Modelo;

namespace ProjetoDotNet2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Depoimento> Depoimento { get; set; }
    }
}
