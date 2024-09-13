using Microsoft.EntityFrameworkCore;
using PernixASP.NET_Razor.Models;

namespace PernixASP.NET_Razor.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }


    }
}
