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
    public class AgendaMap : IEntityTypeConfiguration<Agenda>
    {
        public void Configure(EntityTypeBuilder<Agenda> builder)
        {
            builder.ToTable("Agenda");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Codigo)
                .IsRequired();
            builder.Property(prop => prop.Data_Efetuva)
                .IsRequired();

            builder.Property(prop => prop.Vagas)
                .IsRequired();

            builder.HasOne(prop => prop.Profissional);

        }
    }
}
