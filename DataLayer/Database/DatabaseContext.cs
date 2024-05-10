using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Others;

namespace DataLayer.Database
{
    public class DatabaseContext:DbContext
    {
        public DbSet<DatabaseUser> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string solutionFolder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string databaseFile = "Welcome.db";
            string databasePath = Path.Combine(solutionFolder, databaseFile);
            optionsBuilder.UseSqlite($"Data Source={databasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DatabaseUser>().Property(e => e.Id).ValueGeneratedOnAdd();

            var user = new DatabaseUser()
            {
                Id = 1,
                Names = "John Doe",
                Password = "password",
                Role = UserRolesEnum.ADMIN,
                Expires = DateTime.Now.AddYears(10)
            };

            modelBuilder.Entity<DatabaseUser>()
                .HasData(user);

            var user1 = new DatabaseUser()
            {
                Id = 2,
                Names = "Bai Ivan",
                Password = "password123",
                Role = UserRolesEnum.PROFESSOR,
                Expires = DateTime.Now.AddYears(9)
            };

            modelBuilder.Entity<DatabaseUser>()
                .HasData(user1);

            var user2 = new DatabaseUser()
            {
                Id = 3,
                Names = "Yanko Tigura",
                Password = "password1Tigur",
                Role = UserRolesEnum.STUDENT,
                Expires = DateTime.Now.AddYears(8)
            };

            modelBuilder.Entity<DatabaseUser>()
                .HasData(user2);
        }
    }
}
