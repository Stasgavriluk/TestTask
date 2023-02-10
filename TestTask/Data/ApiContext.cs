using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;
using TestTask.Models;

namespace TestTask.Data
{
    public class ApiContext : DbContext
    {
        public DbSet<Device> Devices { get; set; }

        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {

        }

        private static readonly string[] Values = new[]
        {
            "#FF0000", "#00FF00", "#0000FF"
        };
        private static readonly string[] Keys = new[]
        {
        "button_color"
        };
        private static Random random = new Random();
        int price = random.Next(0, 100);
        int finalPrice;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (price < 75)
            {
                finalPrice = 10;
            }
            else if (price < 85)
            {
                finalPrice = 20;
            }
            else if (price < 90)
            {
                finalPrice = 50;
            }
            else finalPrice = 5;
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Device>().HasData(new Device
            {
                Id = 1,
                Key = Keys[0],
                Value = Values[Random.Shared.Next(Values.Length)],
                Price = finalPrice

            });
            modelBuilder.Entity<Device>().HasData(new Device
            {
                Id = 2,
                Key = Keys[0],
                Value = Values[Random.Shared.Next(Values.Length)],
                Price = finalPrice
            });
            modelBuilder.Entity<Device>().HasData(new Device
            {
                Id = 3,
                Key = Keys[0],
                Value = Values[Random.Shared.Next(Values.Length)],
                Price = finalPrice
            });
            modelBuilder.Entity<Device>().HasData(new Device
            {
                Id = 4,
                Key = Keys[0],
                Value = Values[Random.Shared.Next(Values.Length)],
                Price = finalPrice
            });
            modelBuilder.Entity<Device>().HasData(new Device
            {
                Id = 5,
                Key = Keys[0],
                Value = Values[Random.Shared.Next(Values.Length)],
                Price = finalPrice
            });
        }
    }
}

