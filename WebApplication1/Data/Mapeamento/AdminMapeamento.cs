using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Data.Mapeamento
{
    public class AdminMapeamento : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.ToTable("Admin");

            builder.HasKey(t => t.Id);
        

            builder.Property(t => t.Usuario).HasColumnType("varchar(50)");
            builder.Property(t => t.Senha).HasColumnType("varchar(50)");

        }
    }
}