using DAL_DiyetProgrami.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_DiyetProgrami.Context
{
    public class DiyetProgramiDbContext :DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Ogun> Ogunler { get; set; }
        public DbSet<Yemek> Yemekler { get; set; }
        public DbSet<YemekKatagorisi> YemekKatagorileri { get; set; }
        public DbSet<Yonetici> Yoneticiler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=DESKTOP-QJIAQ3L;Database=ANK18ProductDb;Trusted_Connection=True;Encrypt=No";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
