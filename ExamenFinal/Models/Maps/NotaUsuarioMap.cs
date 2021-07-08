using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExamenFinal.Models.Maps
{
    public class NotaUsuarioMap : IEntityTypeConfiguration<NotaUsuario>
    {
        public void Configure(EntityTypeBuilder<NotaUsuario> builder)
        {
            builder.ToTable("NotaUsuario");
            builder.HasKey(o => new{o.NotaId, o.UserId});
            builder.HasOne(x => x.Nota)
                .WithMany()
                .HasForeignKey(x => x.NotaId);
        }
    }
    
}
