using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using wherapp_gsk.Models;

namespace wherapp_gsk.Services
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Content> Contents { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<SubCategory> SubCategory { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Introduction> Introductions { get; set; }
        public DbSet<ContentStatus> ContentStatuses { get; set; }
        public DbSet<ContentType> ContentsTypes { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Permission> Permisions { get; set;}
        public DbSet<State> States { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Address> addresses { get; set; }
        public DbSet<Specification> Specifications { get; set; }
        public DbSet<SubSpecification> SubSpecifications { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DatabaseContext() : base("SystemDbContext") { }
        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
            /*builder.Entity<Content>().ToTable("Contents");
            builder.Entity<ContentStatus>().ToTable("ContentStatus");
            builder.Entity<ContentType>().ToTable("ContentTypes");
            builder.Entity<Image>().ToTable("Images");
            builder.Entity<User>().ToTable("Users");
            builder.Entity<Permission>().ToTable("Permissions");*/
            
          /*  builder.Entity<Image>()
                    .HasOptional(i => i.Content)
                    .WithMany(pc => pc.Images)
                    .HasForeignKey(i => i.ContentID);*/
        }
       /* public int SaveAllChanges(bool invalidateCacheDependencies)
        {
            return SaveChanges(invalidateCacheDependencies);
        }

        public async Task<int> SaveAllChangesAsync(bool invalidateCacheDependencies)
        {

            return await SaveChangesAsync(invalidateCacheDependencies);
        }

        public int SaveChanges(bool invalidateCacheDependencies)
        {
            var result = base.SaveChanges();

            return result;
        }

        public async Task<int> SaveChangesAsync(bool invalidateCacheDependencies)
        {
            var result = await base.SaveChangesAsync();

            return result;
        }*/
    }
    
        
}