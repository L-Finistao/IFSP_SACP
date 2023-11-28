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
    public class Medico_EspecialidadesMap : IEntityTypeConfiguration<Medico_Especialidades>
    {
        public void Configure(EntityTypeBuilder<Medico_Especialidades> builder)
        {
            builder.ToTable("Medico_Especialidades");

            builder.HasKey(prop => prop.Id);

            builder.HasOne(prop => prop.IdMedico);

            builder.HasOne(prop => prop.Categoria_Especialidade);
        }
    }
}
