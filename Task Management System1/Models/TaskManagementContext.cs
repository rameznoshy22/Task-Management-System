using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Task_Management_System;

namespace Task_Management_System1.Models
{
    internal class TaskManagementContext : DbContext
    {
        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-2JDFSHG\SQLEXPRESS;Initial Catalog=TaskSYS;Trusted_Connection=True;Integrated Security=True;TrustServerCertificate=True");

            // Uncomment if you want to enable logging
            // optionsBuilder.LogTo(log => Debug.WriteLine(log));

            // Uncomment if you want to enable lazy loading
            // optionsBuilder.UseLazyLoadingProxies(true);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships using Fluent API
            modelBuilder.Entity<TaskItem>()
                .HasOne(t => t.User)
                .WithMany(u => u.Tasks)
                .HasForeignKey(t => t.UserId);

            modelBuilder.Entity<TaskItem>()
                .HasOne(t => t.Category)
                .WithMany(c => c.Tasks)
                .HasForeignKey(t => t.CategoryId);

            // Uncomment if you want to configure the relationship between Category and User
            // modelBuilder.Entity<Category>()
            //     .HasOne(c => c.User)
            //     .WithMany()
            //     .HasForeignKey(c => c.UserId)
            //     .OnDelete(DeleteBehavior.Restrict); // Disable cascade delete

            base.OnModelCreating(modelBuilder);
        }
    }
}