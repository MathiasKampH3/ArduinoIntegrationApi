using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArduinoIntegrationApi.DataModels;
using Microsoft.EntityFrameworkCore;

namespace ArduinoIntegrationApi.Context
{
    public class ArduinoApiContext : DbContext
    {
        public DbSet<Room> Rooms { get; set; }
        public DbSet<TemperatureSensor> TemperatureSensors { get; set; }

        public DbSet<LightSensor> LightSensors { get; set; }

        public DbSet<WindowLock> WindowLocks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=192.168.1.72;Database=ArduinoApiDb;User ID=admdb; Password=Kode1234!;");
        }
    }
}
