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
    public class CidMap : IEntityTypeConfiguration<Cid>
    {
        public void Configure(EntityTypeBuilder<Cid> builder)
        {
            builder.ToTable("Cid");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Codigo_CID)
                .IsRequired()
                .HasColumnType("varchar(4)");
            builder.Property(prop => prop.Descricao)
               .IsRequired()
               .HasColumnType("varchar(255)");
        }
    }

}
