using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using DataModels.Models;

namespace BackEnd
{
    public class AppDbContext : DbContext
    {
        public AppDbContext([NotNullAttribute] DbContextOptions options) : base(options) { }
        public DbSet<Profesori> Profesori { get; set; }
        public DbSet<Facultate> Facultate { get; set; }
        public DbSet<DataModels.Models.Materie> Materie { get; set; }
        public DbSet<DataModels.Models.Orar> Orar { get; set; }
        public DbSet<DataModels.Models.Sala> Sala { get; set; }
        public DbSet<DataModels.Models.Specializare> Specializare { get; set; }
        public DbSet<DataModels.Models.Student> Student { get; set; }
    }
}
