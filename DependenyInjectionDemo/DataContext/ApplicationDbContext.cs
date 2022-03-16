using DependenyInjectionDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependenyInjectionDemo.DataContext
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> context) : base(context)
        { }
        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent Api
            // Seed data , to provide some data
            modelBuilder.Entity<Student>().HasData(
                new Student() { Id=1, Name="Ajay", Batch="B001", Marks=90},
                 new Student() { Id = 2, Name = "Deepak", Batch = "B002", Marks = 67 },
                  new Student() { Id = 3, Name = "Sagar", Batch = "B003", Marks = 89 }
                );
        }
    }
}
