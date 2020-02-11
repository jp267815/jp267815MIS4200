using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using jp267815MIS4200.Models; //this is needed to access the models
using System.Data.Entity; //this is needed to access the DbContext object

namespace jp267815MIS4200.DAL
{
    public class MIS4200Context : DbContext //inherits from DbContext
    {
        public MIS4200Context() : base ("name=DefaultConnection")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<MIS4200Context,jp267815MIS4200.Migrations.MISContext.Configuration>("DefaultConnection"));
        }

        public DbSet <Course> Courses { get; set; }
        public DbSet <Student> Students { get; set; }

        public DbSet <Grade> Grades { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}