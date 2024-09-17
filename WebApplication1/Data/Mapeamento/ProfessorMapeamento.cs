using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Data.Mapeamento
{
    public class ProfessorMapeamento : IEntityTypeConfiguration<Professor>
    {
        public void Configure(EntityTypeBuilder<Professor> builder)
        {
            builder.ToTable("Professor");

            builder.HasKey(t => t.Id);
        

            builder.Property(t => t.Nome).HasColumnType("varchar(100)");
            builder.Property(t => t.Materia).HasColumnType("varchar(50)");
            builder.Property(t => t.Cpf).HasColumnType("varchar(11)");

        }
    }
}