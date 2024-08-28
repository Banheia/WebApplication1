using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApplication1.Models;

namespace WebApplication1.Data.Mapeamento
{
    public class AlunoMapeamento : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");

            builder.HasKey(t => t.Id);
        

            builder.Property(t => t.Nome).HasColumnType("varchar(100)");
            builder.Property(t => t.Idade).HasColumnType("int");
            builder.Property(t => t.Cpf).HasColumnType("varchar(11)");

        }
    }
}