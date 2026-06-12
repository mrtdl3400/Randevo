using Microsoft.EntityFrameworkCore;
using Randevo.VarlikKatmani;

namespace Randevo.VeriErisimKatmani.Baglamlar
{
    public class RandevoDbContext : DbContext
    {
        public RandevoDbContext(DbContextOptions<RandevoDbContext> options)
            : base(options)
        {
        }

        public DbSet<Kullanici> Kullanicilar { get; set; }

        public DbSet<Isletme> Isletmeler { get; set; }

        public DbSet<Musteri> Musteriler { get; set; }

        public DbSet<Personel> Personeller { get; set; }

        public DbSet<Hizmet> Hizmetler { get; set; }

        public DbSet<Randevu> Randevular { get; set; }

        public DbSet<Odeme> Odemeler { get; set; }

        public DbSet<Bildirim> Bildirimler { get; set; }
    }
}
