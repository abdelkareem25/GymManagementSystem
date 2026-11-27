using GYMManagementSystem.Entites;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace GYMManagementSystem.Context
{
    public class GYM_DbContext : DbContext
    {
        public GYM_DbContext(DbContextOptions<GYM_DbContext> options) : base(options)
        {

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
