using Blog.Models;

class PostagenDb : DbContext
{
    public PostagenDb(DbContextOptions options) : base(options) { }
    public DbSet<Postagen> Postagen { get; set; } = null!;
}