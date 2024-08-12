using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Safaa_First_Project_DotNet8_API.Models;

namespace Safaa_First_Project_DotNet8_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }


        public  DbSet <Comment> Comments { get; set; }
    }
}
