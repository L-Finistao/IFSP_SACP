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
    public class Categoria_EspecialidadeMap : IEntityTypeConfiguration<CategoriaEspecialidade>
    {
        public void Configure(EntityTypeBuilder<CategoriaEspecialidade> builder)
        {
            builder.ToTable("categoria_especialidade");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Codigo)
                .IsRequired()
               .HasColumnType("varchar(150)");
            builder.Property(prop => prop.Nome)
               .IsRequired()
               .HasColumnType("varchar(150)");
        }
    }
}
