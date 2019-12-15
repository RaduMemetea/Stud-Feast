using DataModels.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace BackEnd
{
    public class AppDbContext : DbContext
    {
        public AppDbContext([NotNullAttribute] DbContextOptions options) : base(options) { }
        public DbSet<Profesori> Profesori { get; set; }
        public DbSet<Facultate> Facultate { get; set; }
        public DbSet<Materie> Materie { get; set; }
        public DbSet<Orar> Orar { get; set; }
        public DbSet<Sala> Sala { get; set; }
        public DbSet<Specializare> Specializare { get; set; }
        public DbSet<Student> Student { get; set; }
    }
}
