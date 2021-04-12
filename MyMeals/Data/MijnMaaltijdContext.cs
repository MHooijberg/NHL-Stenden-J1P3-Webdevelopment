using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Runtime;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using MyMeals.Models;

#nullable disable

namespace MyMeals.Data
{
    public partial class MijnMaaltijdContext : IdentityDbContext
    { 
        public MijnMaaltijdContext(DbContextOptions<MijnMaaltijdContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Adres> Adres { get; set; }
        public virtual DbSet<Gebruiker> Gebruikers { get; set; }
        public virtual DbSet<Maaltijd> Maaltijds { get; set; }
        public virtual DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=127.0.0.1;Initial Catalog=MijnMaaltijd;User ID=root;Password=root");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AS");

            modelBuilder.Entity<Adres>(entity =>
            {
                entity.HasKey(e => e.AdresId)
                    .HasName("PK__Adres__DA8DEA6CB75AD8A2");

                entity.Property(e => e.AdresId).HasColumnName("AdresID");

                entity.Property(e => e.Huisnummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Postcode)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Straat)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Woonplaats)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gebruiker>(entity =>
            {
                entity.ToTable("Gebruiker");

                entity.Property(e => e.GebruikerId).HasColumnName("GebruikerID");

                entity.Property(e => e.AchterNaam)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.AdresId).HasColumnName("AdresID");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProfielNaam)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Telefoonnummer)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.VoorNaam)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Wachtwoord)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Adres)
                    .WithMany(p => p.Gebruikers)
                    .HasForeignKey(d => d.AdresId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Gebruiker__Adres__38996AB5");
            });

            modelBuilder.Entity<Maaltijd>(entity =>
            {
                entity.ToTable("Maaltijd");

                entity.Property(e => e.MaaltijdId).HasColumnName("MaaltijdID");

                entity.Property(e => e.GebruikerId).HasColumnName("GebruikerID");

                entity.Property(e => e.Ingredienten)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Naam)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Gebruiker)
                    .WithMany(p => p.Maaltijds)
                    .HasForeignKey(d => d.GebruikerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Maaltijd__Gebrui__3B75D760");
            });

            modelBuilder.Entity<Post>(entity =>
            {
                entity.ToTable("Post");

                entity.Property(e => e.PostId).HasColumnName("PostID");

                entity.Property(e => e.BereidOp).HasColumnType("date");

                entity.Property(e => e.Beschrijving)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.GebruikerId).HasColumnName("GebruikerID");

                entity.Property(e => e.HoudbaarTot).HasColumnType("date");

                entity.Property(e => e.MaaltijdId).HasColumnName("MaaltijdID");

                entity.Property(e => e.PostNaam)
                    .IsRequired()
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Gebruiker)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.GebruikerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Post__GebruikerI__3E52440B");

                entity.HasOne(d => d.Maaltijd)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.MaaltijdId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Post__MaaltijdID__3F466844");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
