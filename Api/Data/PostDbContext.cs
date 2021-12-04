using Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data;
public class PostDbContext: DbContext
{
    public DbSet<Post> Posts { get; set; }
    
    public DbSet<Media> Medias { get; set; }
    
    public DbSet<Comment> Comments { get; set; }

    public PostDbContext(DbContextOptions options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Media>()
            .HasOne(b => b.Post)
            .WithMany(b => b.Medias)
            .HasForeignKey(b => b.PostId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}

        

