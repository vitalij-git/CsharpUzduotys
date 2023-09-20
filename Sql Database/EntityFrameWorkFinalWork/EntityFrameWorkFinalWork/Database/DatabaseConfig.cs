using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarpinis_atsikaitymas.Models;


namespace Tarpinis_atsikaitymas.Database
{
    public class DatabaseConfig : DbContext
    {
        public DatabaseConfig()
        {
            ConnString = "Data Source=DESKTOP-O7DTL46;Initial Catalog=DBFinalWork;Integrated Security=True; TrustServerCertificate=true";
        }
        public string ConnString { get; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Department> Departaments { get; set; }    
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<DepartmentLecture> DepartmentLectures { get; set; }
        public DbSet<StudentLecture> StudentLectures { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DepartmentLecture>().HasKey(dl => new {dl.DepartmentId,dl.LectureId});
            modelBuilder.Entity<StudentLecture>().HasKey(sl => new {sl.StudentId,sl.LectureId});
            modelBuilder.Entity<Student>().HasOne<Department>(d => d.Departament).WithMany(g => g.Students);

        }
    }
}
