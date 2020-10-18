using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace NatureBoysStats.Models
{
    public partial class HockeyContext : DbContext
    {
        public HockeyContext()
        {
        }

        public HockeyContext(DbContextOptions<HockeyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<GolfScoreCard> GolfScoreCard { get; set; }
        public virtual DbSet<NatureBoys> NatureBoys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\sqlexpress;Database=Hockey;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GolfScoreCard>(entity =>
            {
                entity.Property(e => e.CourseName).HasMaxLength(100);
                entity.Property(e => e.Date).HasMaxLength(20);

                //entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.PlayerName).HasMaxLength(100);
            });

            modelBuilder.Entity<NatureBoys>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.NickName).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
