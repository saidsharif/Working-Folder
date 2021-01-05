using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace mywebapi.Models
{
    public class mywebapiContext : DbContext
    {
        public mywebapiContext(DbContextOptions<mywebapiContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
    public class mywebapiContextDbFactory : IDesignTimeDbContextFactory<mywebapiContext>
    {
        mywebapiContext IDesignTimeDbContextFactory<mywebapiContext>.CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<mywebapiContext>();
            optionsBuilder.UseNpgsql<mywebapiContext>("User ID = postgres;Password=1234;Server=localhost;Port=5432;Database=MyCoreApi.Dev;Integrated Security=true; Pooling=true;");

            return new mywebapiContext(optionsBuilder.Options);
           
        }
    }
}
