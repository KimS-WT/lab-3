using System;
using Microsoft.EntityFrameworkCore;

namespace lab3 // You can use any namespace you like. Remember to add the using directive to Program.cs
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=database.db");
        }
        public DbSet<MadScientist> MadScientists {get;set;} =null!; // Tells DbContext to put MadScientist class into database and it will not be null

    } 
}