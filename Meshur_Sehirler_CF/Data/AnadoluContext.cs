using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meshur_Sehirler_CF.Data
{
    public class AnadoluContext : DbContext
    {
        public DbSet<Sehir> Sehirler => Set<Sehir>();

        public DbSet<Ozellik> Ozellikler => Set<Ozellik>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // DLUENT API ILE MAPPING CONFIGURATION
            // modelBuilder.Entity<Ozellik>().ToTable("Features");  // Sehir sınıfı table adlandırma aynı
            //modelBuilder
            // .Entity<Sehir>()
            // .Property(s => s.Ad)     // kolon adlandırma
            // .HasMaxLength(50);       // IsRequired(); -- sona .IsRequired() yazınca girmek zorunlu oluyor

            modelBuilder.Entity<Sehir>().HasData(
                new Sehir() { Plaka = 21, Ad = "Diyarbakır" },
                new Sehir() { Plaka = 44, Ad = "Malatya" },
                new Sehir() { Plaka = 38, Ad = "Kayseri" }
            );

            modelBuilder.Entity<Ozellik>().HasData(
               new Ozellik() { Id = 1, Ad = "Karpuz", SehirId = 21 },
               new Ozellik() { Id = 2, Ad = "Kayısı", SehirId = 44 },
               new Ozellik() { Id = 3, Ad = "Mantı", SehirId = 38 },
               new Ozellik() { Id = 4, Ad = "Pastıma", SehirId = 38 }
            );

            }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"server=(localdb)\MSSQLLocalDB;database=AnadoluDB;trusted_connection=true");
            }

    }
}

