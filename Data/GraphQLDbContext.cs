using GraphQLProject.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQLProject.Data;

public class GraphQLDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data source=application.db");
        base.OnConfiguring(optionsBuilder);
    }

    public DbSet<Menu> Menus { get; set; }
}