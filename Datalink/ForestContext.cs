using DomainOfModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace Datalink
{
    //public class ApplicationDbContext : DbContext
    //{
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Test");
        //}
    //}

    public class ForestContext : DbContext
    {
        public DbSet<Forest> Forest { get; set; }
        public DbSet<Tree> Trees { get; set; }

        public ForestContext(DbContextOptions options) : base(options)
        {

        }
    }
}
