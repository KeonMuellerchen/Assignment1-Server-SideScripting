namespace Assign1.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NbaModel : DbContext
    {
        public NbaModel()
            : base("name=DefaultConnection")
        {
        }

        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Player>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.lastName)
                .IsUnicode(false);

            modelBuilder.Entity<Player>()
                .Property(e => e.pointsPerGame)
                .HasPrecision(3, 1);

            modelBuilder.Entity<Team>()
                .Property(e => e.city)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.teamName)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .Property(e => e.stadium)
                .IsUnicode(false);

            modelBuilder.Entity<Team>()
                .HasMany(e => e.Players)
                .WithRequired(e => e.Team)
                .WillCascadeOnDelete(false);
        }
    }
}
