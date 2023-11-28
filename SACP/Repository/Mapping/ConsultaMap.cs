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
    public class ConsultaMap : IEntityTypeConfiguration<Consulta>
    {
        public void Configure(EntityTypeBuilder<Consulta> builder)
        {
            builder.ToTable("Consulta");

            builder.HasKey(prop => prop.Id);
            builder.Property(prop => prop.Data_criacao)
            .HasDefaultValue(DateTime.Now);
            builder.HasOne(prop => prop.Paciente);

            builder.HasOne(prop => prop.Agenda);


            builder.HasOne(prop => prop.Categoria);


        }
    }
}
