using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebPowerHouseFitness.Models;

namespace WebPowerHouseFitness.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<WebPowerHouseFitness.Models.Gimnasio> Gimnasio { get; set; }

        public DbSet<WebPowerHouseFitness.Models.Usuarios> Usuarios { get; set; }

        public DbSet<WebPowerHouseFitness.Models.Anuncio> Anuncio { get; set; }

        public DbSet<WebPowerHouseFitness.Models.Itinerario> Itinerario { get; set; }

        public DbSet<WebPowerHouseFitness.Models.Perfil> Perfil { get; set; }
    }
}
