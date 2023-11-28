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

        public DbSet<Usuario>? Usuarios { get; set; }
        public DbSet<Usuario_Medico>? usuario_Medicos { get; set; }
        public DbSet<Cid>? CIDs { get; set; }
        public DbSet<CategoriaEspecialidade>? Categoria_Especialidades { get; set; }
        public DbSet<CategoriaConsulta>? Categoria_Consultas { get; set; }
        public DbSet<Medico_Especialidades>? medico_Especialidades { get; set; }
        public DbSet<Procedimento>? procedimentos { get; set; }
        public DbSet<Agenda>? Agendas { get; set; }
        public DbSet<Consulta>? Consultas { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Usuario>(new UsuarioMap().Configure);
            modelBuilder.Entity<Usuario_Medico>(new UsuarioMedicoMap().Configure);
            modelBuilder.Entity<Cid>(new CidMap().Configure);
            modelBuilder.Entity<CategoriaEspecialidade>(new Categoria_EspecialidadeMap().Configure);
            modelBuilder.Entity<CategoriaConsulta>(new Categoria_ConsultaMap().Configure);
            modelBuilder.Entity<Medico_Especialidades>(new Medico_EspecialidadesMap().Configure);
            modelBuilder.Entity<Procedimento>(new ProcedimentoMap().Configure);
            modelBuilder.Entity<Agenda>(new AgendaMap().Configure);
            modelBuilder.Entity<Consulta>(new ConsultaMap().Configure);
        }
    }
}
