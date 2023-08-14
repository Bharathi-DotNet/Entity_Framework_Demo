using Microsoft.EntityFrameworkCore;
using Multhalvan.Models;

namespace Multhalvan.data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext>Options):base(Options)
        {

        }
        public DbSet<Studets> student { set; get; }

            
    }

   
}
