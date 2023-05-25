using Microsoft.EntityFrameworkCore;
using MvcApp.Models.Entities;

namespace MvcApp.Models.Context
{
    public class MvcDbContext : DbContext
    {
        DbSet<Advisor> Advisors { get; set; } 
        DbSet<Department> Departments { get; set; }
        DbSet<Subject> Subjects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Advisor>(a =>
            {
                a.ToTable("Advisors").HasKey(s => s.Id);
                a.Property(p => p.Id).HasColumnName ("Id");
                a.Property(p => p.FName).HasColumnName("FName");
                a.Property(p => p.LName).HasColumnName("LName");
            });
            modelBuilder.Entity<Department>(a =>
            {
                a.ToTable("Departments").HasKey(d => d.Id);
                a.Property(p => p.Id).HasColumnName("Id");
                a.Property(p => p.DeptName).HasColumnName("DeptName");
                a.Property(p => p.DeptCodeNavigation).HasColumnName("DeptCodeNavigation");
            });
            //modelBuilder.Entity<Student>(a =>
            //{
            //    a.ToTable("Students").HasKey(s => s.Id);
            //    a.Property(p => p.Id).HasColumnName("Id");
            //    a.Property(p => p.StudentName).HasColumnName("StudentName");
            //});
            modelBuilder.Entity<Subject>(a =>
            {
                a.ToTable("Subjects").HasKey(a => a.Id);
                a.Property(s => s.Id).HasColumnName("Id");
                a.Property(s => s.SubjectName).HasColumnName("SubjectName");
                a.Property(s => s.Description).HasColumnName("Description");
                a.Property(s => s.WeeklyHours).HasColumnName("WeeklyHours");
                a.Property(s => s.IsElective).HasColumnName("IsElective");
            });
        }
    }

}
