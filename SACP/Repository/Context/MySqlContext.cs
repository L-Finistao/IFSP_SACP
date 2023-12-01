    using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Repository.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Context
{
    public sealed class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) : base(options)
        {
            Database.EnsureCreated();
            ChangeTracker.LazyLoadingEnabled = false;
        }

        public DbSet<Entity_Agenda>? Agenda{ get; set; }
        public DbSet<Entity_Consulta>? Consulta { get; set; }
        public DbSet<Entity_Procedimento>? Procedimento{ get; set; }
        public DbSet<Entity_Usuario>? Paciente{ get; set; }
        public DbSet<Entity_Usuario_Medico>? Medico{ get; set; }
      


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Entity_Usuario>(new Entity_MapUsuario().Configure);
            modelBuilder.Entity<Entity_Usuario_Medico>(new Entity_MapUsuarioMedico().Configure);
            modelBuilder.Entity<Entity_Procedimento>(new Entity_MapProcedimento().Configure);
            modelBuilder.Entity<Entity_Agenda>(new Entity_MapAgenda().Configure);
            modelBuilder.Entity<Entity_Consulta>(new Entity_MapConsulta().Configure);
        }
    }
}
