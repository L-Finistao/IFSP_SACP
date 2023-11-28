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
    public class Categoria_ConsultaMap : IEntityTypeConfiguration<CategoriaConsulta>
    {
        public void Configure(EntityTypeBuilder<CategoriaConsulta> builder)
        {
            builder.ToTable("Categoria_Consulta");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Codigo)
                .IsRequired()
                .HasColumnType("varchar(7)");
            builder.Property(prop => prop.Nome)
               .IsRequired()
               .HasColumnType("varchar(255)");
        }
    }
}
