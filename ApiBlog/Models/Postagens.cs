using Microsoft.EntityFrameworkCore;

namespace ApiBlog.Models
{
    public class Postagem
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Assunto { get; set; }
        public string? Conteudo { get; set; }
    }

    public class PostagenDb : DbContext
    {
        public PostagenDb(DbContextOptions<PostagenDb> options) : base(options) { }
        public DbSet<Postagem> Postagens { get; set; }
    }
}