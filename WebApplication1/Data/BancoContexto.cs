﻿using Microsoft.EntityFrameworkCore;
using WebApplication1.Data.Mapeamento;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
                modelBuilder.ApplyConfiguration(new AlunoMapeamento());
                modelBuilder.ApplyConfiguration(new ProfessorMapeamento());
                modelBuilder.ApplyConfiguration(new AdminMapeamento());
        }

        public DbSet<Aluno> aluno { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Admin> Admin { get; set; }
    }  
}
