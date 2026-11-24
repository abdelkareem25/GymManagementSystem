using GYMManagementSystem.Entites;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GYMManagementSystem.Context
{
    public class GYM_DbContext : DbContext
    {
        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=GYMManagementSystem;Trusted_Connection=True;TrustServerCertificate=True");
        }
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
        #region Tables
        public DbSet<Session> sessions { get; set; }
        public DbSet<Member> members { get; set; }
        public DbSet<Trainer> trainers { get; set; }
        public DbSet<MemberShip> MemberShips { get; set; }
        public DbSet<Plan> plans { get; set; }
        #endregion
    }
}
