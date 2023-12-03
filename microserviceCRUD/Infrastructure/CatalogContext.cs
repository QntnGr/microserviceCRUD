using microserviceCRUD.Entities;
using Microsoft.EntityFrameworkCore;

namespace microserviceCRUD.Infrastructure
{
    public class CatalogContext : DbContext
    {
        public DbSet<CatalogItem> CatalogItems { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public string DbPath { get; }

        public CatalogContext(DbContextOptions<CatalogContext> options) : base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = Path.Join(path, "persons.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }
}
