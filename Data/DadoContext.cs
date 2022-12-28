
using Ef.Models;
using Microsoft.EntityFrameworkCore;

namespace Ef.Data{
    public class DadoContext : DbContext
    
    {
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tag> Tags { get; set; }
        //public DbSet<UsuarioCargo> UsuarioCargos { get; set; }
        //public DbSet<PosTag> PosTags { get; set; }
        
        protected override void OnConfiguring( DbContextOptionsBuilder opcao){
            opcao.UseSqlServer("Server=localhost,1433;Database=Blog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=True");
        }
    }
}