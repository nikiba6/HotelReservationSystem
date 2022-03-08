using HotelReservation.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelReservation.Infrastructure
{
    public class HotelReservationDbContext : DbContext

    {
        public DbSet<User> Users { get; set; }
        public DbSet<Maisonette>Maisonettes{get;set;}
        public DbSet<UserMaisonette> UserMaisonettes { get; set; }

        public HotelReservationDbContext(DbContextOptions<HotelReservationDbContext> options)
       : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-IKP5H39\MSSQLSERVER01;Database=HotelReservation;Integrated Security=True;");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserMaisonette>().HasKey(up => new { up.UserId, up.MaisonetteId });
        }
    }
}