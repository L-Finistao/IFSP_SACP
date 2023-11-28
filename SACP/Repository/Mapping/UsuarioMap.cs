using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(56)");
            builder.Property(prop => prop.Vinculo)
              .IsRequired()
              .HasColumnType("varchar(50)");
            builder.Property(prop => prop.Dt_Nasci)
              .IsRequired();
            builder.Property(prop => prop.Telefone_01);
            builder.Property(prop => prop.Telefone_02);

        }
    }
}
