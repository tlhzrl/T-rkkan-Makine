using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TürkkannMakinaa.Entities
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<ProductRate> ProductRate { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Product>()
            .HasOne(i => i.Categories)
            .WithMany(c => c.Product)
            .OnDelete(DeleteBehavior.SetNull);


            builder.Entity<ProductPhoto>()
           .HasOne(i => i.Product)
           .WithMany(c => c.Photos)
           .OnDelete(DeleteBehavior.SetNull);

            base.OnModelCreating(builder);
        }

    }
}
