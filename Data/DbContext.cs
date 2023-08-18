using Microsoft.EntityFrameworkCore;
using TodoProject.Models;

namespace TodoProject.Data;
public class TodoContext : DbContext
{

    public DbSet<Todo> Todos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=todo.db");
    }
}