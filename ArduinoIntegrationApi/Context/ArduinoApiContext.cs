using ArduinoIntegrationApi.DataModels;
using Microsoft.EntityFrameworkCore;

namespace ArduinoIntegrationApi.Context
{
    public class ArduinoApiContext : DbContext
    {
        public DbSet<RoomReading> RoomDatas { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=192.168.2.129;Database=ArduinoApiDb;User ID=admdb; Password=Kode1234!;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomReading>()
                .HasKey(rd => new {rd.Rd_RoomName, rd.Rd_Cts});
        }   
    }
}