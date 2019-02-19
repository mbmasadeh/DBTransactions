using DBTransactions.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBTransactions.DataBase
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            //
        }
        public DbSet<Students> Students { get; set; }
        public DbSet<Courses> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Students>().ToTable("Students");
            modelBuilder.Entity<Courses>().ToTable("Courses");
            modelBuilder.Entity<StudentCourse>().ToTable("StudentCourse");
        }
    }
}
