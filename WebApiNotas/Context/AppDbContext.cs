using Microsoft.EntityFrameworkCore;
using WebApiNotas.Models;

namespace WebApiNotas.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<Note> Notes { get; set; }
    }
}
