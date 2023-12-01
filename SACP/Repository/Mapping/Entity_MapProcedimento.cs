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
    public class Entity_MapProcedimento : IEntityTypeConfiguration<Entity_Procedimento>
    {
        public void Configure(EntityTypeBuilder<Entity_Procedimento> builder)
        {
            builder.ToTable("Procedimento");

            builder.HasKey(prop => prop.Id);


            builder.Property(prop => prop.Descricao)
              .IsRequired()
              .HasColumnType("varchar(250)");
            builder.Property(prop => prop.Data_Agendado);

            builder.Property(prop => prop.Cid)
                .IsRequired()
                .HasColumnType("varchar(9)");
            builder.HasOne(prop => prop.Id_Paciente);
            builder.HasOne(prop => prop.Id_Medico);
        }
    }
}
