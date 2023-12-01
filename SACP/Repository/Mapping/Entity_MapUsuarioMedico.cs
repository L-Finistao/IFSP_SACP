using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Mapping
{
    public class Entity_MapUsuarioMedico : IEntityTypeConfiguration<Entity_Usuario_Medico>
    {
        public void Configure(EntityTypeBuilder<Entity_Usuario_Medico> builder)
        {
            builder.ToTable("Medico");

            builder.HasKey(prop => prop.Id);


            builder.Property(prop => prop.Endereco)
              .IsRequired()
              .HasColumnType("varchar(150)");

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(56)");
            builder.Property(prop => prop.Vinculo)
              .IsRequired()
              .HasColumnType("varchar(50)");

            builder.Property(prop => prop.Especialidade)
              .IsRequired()
              .HasColumnType("varchar(150)");

            builder.Property(prop => prop.Codigo)
              .IsRequired()
              .HasColumnType("varchar(6)");

            builder.Property(prop => prop.Dt_Nasci)
              .IsRequired();
            builder.Property(prop => prop.Telefone_01);
            builder.Property(prop => prop.Telefone_02);
        }
    }
}
