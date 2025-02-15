﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyMeals.Models;
using MyMeals.Data;

namespace MyMeals.Migrations
{
    [DbContext(typeof(MijnMaaltijdContext))]
    [Migration("20210412085304_CreateIdentitySchema")]
    partial class CreateIdentitySchema
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Latin1_General_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MyMeals.Models.Adres", b =>
                {
                    b.Property<int>("AdresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("AdresID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Huisnummer")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Postcode")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Straat")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Woonplaats")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("AdresId")
                        .HasName("PK__Adres__DA8DEA6CB75AD8A2");

                    b.ToTable("Adres");
                });

            modelBuilder.Entity("MyMeals.Models.Gebruiker", b =>
                {
                    b.Property<int>("GebruikerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("GebruikerID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AchterNaam")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AdresId")
                        .HasColumnType("int")
                        .HasColumnName("AdresID");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProfielNaam")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Telefoonnummer")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("VoorNaam")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Wachtwoord")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.HasKey("GebruikerId");

                    b.HasIndex("AdresId");

                    b.ToTable("Gebruiker");
                });

            modelBuilder.Entity("MyMeals.Models.Maaltijd", b =>
                {
                    b.Property<int>("MaaltijdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MaaltijdID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AfbeeldingId")
                        .HasColumnType("int");

                    b.Property<int>("GebruikerId")
                        .HasColumnType("int")
                        .HasColumnName("GebruikerID");

                    b.Property<string>("Ingredienten")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Naam")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Vegetarisch")
                        .HasColumnType("int");

                    b.HasKey("MaaltijdId");

                    b.HasIndex("GebruikerId");

                    b.ToTable("Maaltijd");
                });

            modelBuilder.Entity("MyMeals.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PostID")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BereidOp")
                        .HasColumnType("date");

                    b.Property<string>("Beschrijving")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Bevroren")
                        .HasColumnType("int");

                    b.Property<int>("GebruikerId")
                        .HasColumnType("int")
                        .HasColumnName("GebruikerID");

                    b.Property<DateTime>("HoudbaarTot")
                        .HasColumnType("date");

                    b.Property<int>("MaaltijdId")
                        .HasColumnType("int")
                        .HasColumnName("MaaltijdID");

                    b.Property<int>("Porties")
                        .HasColumnType("int");

                    b.Property<string>("PostNaam")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<double?>("Prijs")
                        .HasColumnType("float");

                    b.HasKey("PostId");

                    b.HasIndex("GebruikerId");

                    b.HasIndex("MaaltijdId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("MyMeals.Models.Gebruiker", b =>
                {
                    b.HasOne("MyMeals.Models.Adres", "Adres")
                        .WithMany("Gebruikers")
                        .HasForeignKey("AdresId")
                        .HasConstraintName("FK__Gebruiker__Adres__38996AB5")
                        .IsRequired();

                    b.Navigation("Adres");
                });

            modelBuilder.Entity("MyMeals.Models.Maaltijd", b =>
                {
                    b.HasOne("MyMeals.Models.Gebruiker", "Gebruiker")
                        .WithMany("Maaltijds")
                        .HasForeignKey("GebruikerId")
                        .HasConstraintName("FK__Maaltijd__Gebrui__3B75D760")
                        .IsRequired();

                    b.Navigation("Gebruiker");
                });

            modelBuilder.Entity("MyMeals.Models.Post", b =>
                {
                    b.HasOne("MyMeals.Models.Gebruiker", "Gebruiker")
                        .WithMany("Posts")
                        .HasForeignKey("GebruikerId")
                        .HasConstraintName("FK__Post__GebruikerI__3E52440B")
                        .IsRequired();

                    b.HasOne("MyMeals.Models.Maaltijd", "Maaltijd")
                        .WithMany("Posts")
                        .HasForeignKey("MaaltijdId")
                        .HasConstraintName("FK__Post__MaaltijdID__3F466844")
                        .IsRequired();

                    b.Navigation("Gebruiker");

                    b.Navigation("Maaltijd");
                });

            modelBuilder.Entity("MyMeals.Models.Adres", b =>
                {
                    b.Navigation("Gebruikers");
                });

            modelBuilder.Entity("MyMeals.Models.Gebruiker", b =>
                {
                    b.Navigation("Maaltijds");

                    b.Navigation("Posts");
                });

            modelBuilder.Entity("MyMeals.Models.Maaltijd", b =>
                {
                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
