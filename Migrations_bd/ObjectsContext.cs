using Microsoft.EntityFrameworkCore;

namespace Migrations_bd
{
    class ApplicationContext : DbContext
    {
        public DbSet<gar_address_objects> gar_AddObjCon { get; set; }
        public DbSet<gar_houses> gar_HousesCon { get; set; }
        public DbSet<gar_adm_hier> gar_AdmHierCon { get; set; }
        public DbSet<B4_fias_house> b4_fias_house { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=192.168.1.127;Database=samara_test_13092021;User ID=postgres;Password=1234;");
        }
    }
}
