﻿using Microsoft.EntityFrameworkCore;

namespace Lab5.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Call> Calls { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Subscriber> Subscribers { get; set; }
        public DbSet<Tariff> Tariffs { get; set; }
        
    }
}
