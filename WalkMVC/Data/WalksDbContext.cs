using WalkMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace WalkMVC.Data
{
    public class WalksDbContext : DbContext
    {
        public WalksDbContext(DbContextOptions<WalksDbContext> dbContextOptions) : base (dbContextOptions)
        {
        }
        public DbSet<Region> Regions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            List<Region> regions = new List<Region>()
            {
                new Region()
                {
                    Id = 1,
                    Name = "Lazeshchyna (Yasinna)",
                    Road = "Using train from Lviv or Ivano-Frankivsk is very conveniet and preferable",
                    Spots="You can get to mountais Kukul, Petros, Drahobrat, it`s waterfall, lake Ivor and waterfall Trufanets, ",
                    Links="No links"
                },
                new Region()
                {
                    Id = 2,
                    Name = "Dzembronya",
                    Road = "Using regular (12:00, 15:00 am) bus from Verhovyna, Verhovyna can be reached from Ivano-Frankivsk using bus",
                    Spots = "Able to reach awesome mountain Pip Ivan, Dzembronya and it`s waterfall and even second biggest mountain -- Brebenescyl",
                    Links="No links"
                },
                new Region()
                {
                    Id = 3,
                    Name = "Zaroslak",
                    Road = "Using train or bus to Vorohta, then catching taxi or unregular bus to base Zaroslak",
                    Spots = "Visit Hoverla, polonuna Pozhyzhevska, lake Nesamovute, mountains Rebra, Hytun-Tomnatyk, Shputzi",
                    Links = "No links"
                },
                new Region()
                {
                    Id = 4,
                    Name = "Yaremche",
                    Road = "Using bus from IvanoFrankivsk or train from Frankivsk, Lviv, other cities",
                    Spots = "You can visit various waterfalls, old aqueducs, polonynas and small mountain",
                    Links = "No links"
                }
            };
            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
