using Microsoft.EntityFrameworkCore;
using Biblioteca_Global.Data;

namespace Biblioteca_Global.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }


        //Criando tabelas para as minhas classes
        //Seguindo o modelo de banco TPT
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Autor> Autores { get; set; }
        //public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuração TPT (Tabela por Tipo)
            modelBuilder.Entity<Pessoa>()
                .ToTable("Pessoas"); // Mapeia a classe Pessoa para a tabela "Pessoas"

            modelBuilder.Entity<Funcionario>()
                .ToTable("Funcionarios"); // Mapeia a classe Funcionario para a tabela "Funcionarios"

            modelBuilder.Entity<Cliente>()
                .ToTable("Clientes");

            modelBuilder.Entity<Autor>()
                .ToTable("Autores");
        }
    }
}
