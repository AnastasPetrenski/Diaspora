using Diaspora.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Diaspora.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Gun> Guns { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Ship> Ships { get; set; }
        public DbSet<Equipment> Equipments { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Plan> Plans { get; set; }
        public DbSet<PlanModel> PlanModels { get; set; }
        public DbSet<PlayerShip> PlayerShips { get; set; }
        public DbSet<Pod> Pods { get; set; }
        public DbSet<PlanPlayer> PlanPlayers { get; set; }
        public DbSet<Node> Node { get; set; }
        public DbSet<Mapper> Mappers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<PlayerShip>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.ShipId });
            });

            builder.Entity<Equipment>(entity =>
            {
                entity.HasKey(e => new { e.ShipId, e.PodId });
            });

            builder.Entity<PlanPlayer>(entity =>
            {
                entity.HasKey(e => new { e.PlayerId, e.PlanId });
            });

            builder.Entity<Mapper>(entity =>
            {
                entity.HasKey(e => e.EdgeId);

                entity.HasOne(e => e.NodeFrom)
                .WithMany(n => n.MapsFrom)
                .HasForeignKey(e => e.FromId)
                .OnDelete(DeleteBehavior.Restrict);

                entity.HasOne(e => e.NodeTo)
                .WithMany(n => n.MapsTo)
                .HasForeignKey(e => e.ToId)
                .OnDelete(DeleteBehavior.Restrict);

            });

        }
    }
}
