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
    public class UsuarioMedicoMap : IEntityTypeConfiguration<Usuario_Medico>
    {
        public void Configure(EntityTypeBuilder<Usuario_Medico> builder)
        {
            builder.ToTable("Usuario_Medico");

            builder.HasKey(prop => prop.Id);

            builder.HasOne(prop => prop.UsuarioMedico);

        }
    }
}
