using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using TrackFittNumberTwo.Models;

#nullable disable

namespace TrackFittNumberTwo.Models
{
    public partial class TrackFittDataBase_2Context : DbContext
    {
        public TrackFittDataBase_2Context()
        {
        }

        public TrackFittDataBase_2Context(DbContextOptions<TrackFittDataBase_2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountInfo> AccountInfos { get; set; }
        public virtual DbSet<MacronutrientMeasurement> MacronutrientMeasurements { get; set; }
        public virtual DbSet<Total> Totals { get; set; }
        public DbSet<TrackFittNumberTwo.Models.Master_Food> Master_Food { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\ProjectsV13;Initial Catalog=TrackFittDataBase_2;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AccountInfo>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__AccountI__1788CCAC871750A7");

                entity.ToTable("AccountInfo\r\n");

                entity.Property(e => e.UserId)
                    .ValueGeneratedNever()
                    .HasColumnName("UserID");

                entity.Property(e => e.FirstName).HasColumnName("[First Name]");

                entity.Property(e => e.LastName).HasColumnName("[Last Name]");

                entity.Property(e => e.UserPassword).HasColumnName("[User Password]");
            });

            modelBuilder.Entity<MacronutrientMeasurement>(entity =>
            {
                entity.HasKey(e => e.FoodId)
                    .HasName("PK__Macronut__856DB3CBF67066B8");

                entity.Property(e => e.FoodId)
                    .ValueGeneratedNever()
                    .HasColumnName("FoodID");

                entity.Property(e => e.FoodName).HasColumnName("[Food Name]");
            });

            modelBuilder.Entity<Total>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.TotalCalories).HasColumnName("[Total Calories]");

                entity.Property(e => e.TotalCarbs).HasColumnName("[Total Carbs]");

                entity.Property(e => e.TotalFats).HasColumnName("[Total Fats]");

                entity.Property(e => e.TotalProtein).HasColumnName("[Total Protein]");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

       
    }
}
