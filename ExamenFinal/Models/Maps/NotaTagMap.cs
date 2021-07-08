using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExamenFinal.Models.Maps
{
    public class NotaTagMap : IEntityTypeConfiguration<NotaTag>
    {
        public void Configure(EntityTypeBuilder<NotaTag> builder)
        {
            builder.ToTable("NotaTag");
            builder.HasKey(o => new{o.NotaId,o.TagId});
            builder.HasOne(x => x.Tag)
                .WithMany()
                .HasForeignKey(x => x.TagId);
            builder.HasOne(x => x.Nota)
                .WithMany(x => x.Tags)
                .HasForeignKey(x => x.NotaId);
        }
    }
    
}
