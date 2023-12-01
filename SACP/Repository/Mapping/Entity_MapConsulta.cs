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
    public class Entity_MapConsulta : IEntityTypeConfiguration<Entity_Consulta>
    {
        public void Configure(EntityTypeBuilder<Entity_Consulta> builder)
        {
            builder.ToTable("Consulta");

            builder.HasKey(prop => prop.Id);


            builder.Property(prop => prop.Ativa);
            builder.Property(prop => prop.Realizada);
            builder.HasOne(prop => prop.Paciente);
            builder.HasOne(prop => prop.Agenda);
        }
    }
}
