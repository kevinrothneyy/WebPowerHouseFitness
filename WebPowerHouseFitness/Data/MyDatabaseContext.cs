using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebPowerHouseFitness.Models
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext (DbContextOptions<MyDatabaseContext> options)
            : base(options)
        {
        }


        public DbSet<WebPowerHouseFitness.Models.Gimnasio> Gimnasio { get; set; }

        public DbSet<WebPowerHouseFitness.Models.Usuarios> Usuarios { get; set; }

        public DbSet<WebPowerHouseFitness.Models.Anuncio> Anuncio { get; set; }

        public DbSet<WebPowerHouseFitness.Models.Itinerario> Itinerario { get; set; }

        public DbSet<WebPowerHouseFitness.Models.Perfil> Perfil { get; set; }
    }
}
