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
    public class Entity_MapAgenda : IEntityTypeConfiguration<Entity_Agenda>
    {
        public void Configure(EntityTypeBuilder<Entity_Agenda> builder)
        {
            builder.ToTable("Agenda");

            builder.HasKey(prop => prop.Id);


            builder.HasOne(prop => prop.IdMedico);
            builder.Property(prop => prop.DataAgenda);
            builder.Property(prop => prop.Vagas);
            builder.Property(prop => prop.Vaga_Agendados).HasDefaultValue(0);

        }
    }
}
