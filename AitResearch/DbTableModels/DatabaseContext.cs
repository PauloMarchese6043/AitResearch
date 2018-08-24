using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AitResearch.DbTableModels
{
    public class DatabaseContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public DatabaseContext() : base("name=dbConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<DatabaseContext, Migrations.Configuration>());
        }

        public DbSet<QUESTION> QUESTIONS { get; set; }

        public DbSet<QUESTION_OPTION> QUESTION_OPTIONS { get; set; }

        public DbSet<SESSION> SESSIONS { get; set; }

        public DbSet<STAFF> STAFF { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<QUESTION_OPTION>().HasRequired(x => x.QUESTION).WithMany().WillCascadeOnDelete(false);

            modelBuilder.Entity<QUESTION>().ToTable("QUESTIONS");
            modelBuilder.Entity<QUESTION_OPTION>().ToTable("QUESTIONS_OPTIONS");
            modelBuilder.Entity<SESSION>().ToTable("SESSIONS");
            modelBuilder.Entity<STAFF>().ToTable("STAFF");
        }
    }
}