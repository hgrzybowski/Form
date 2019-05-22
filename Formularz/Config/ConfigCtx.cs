using Formularz.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Formularz.Config
{
    public class ConfigContext : DbContext
    {
        public ConfigContext(): base("socialDb")
        {
            Database.SetInitializer<ConfigContext>(
                new CreateDatabaseIfNotExists<ConfigContext>());
        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Post>().ToTable("Post");
            modelBuilder.Entity<Comment>().ToTable("Comment");
        }
        //Formularz.Config.ConfigContext
    }

    public class UserContext : DbContext
    {
        public UserContext() : base ("userDb")
        {
            Database.SetInitializer<UserContext>(null);
        }

        public DbSet<User> Users { get; set; }
    }

}