﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyMeals.Data;

namespace MyMeals.Migrations.MyMeals
{
    [DbContext(typeof(MyMealsContext))]
    [Migration("20210412130826_CombineUserData")]
    partial class CombineUserData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MyMeals.Areas.Identity.Data.MyMealsUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("AchterNaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AdresId")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("GebruikerId")
                        .HasColumnType("int");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("ProfielNaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefoonnummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("VoorNaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wachtwoord")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AdresId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("MyMeals.Models.Adres", b =>
                {
                    b.Property<int>("AdresId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Huisnummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Postcode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Straat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Woonplaats")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdresId");

                    b.ToTable("Adres");
                });

            modelBuilder.Entity("MyMeals.Models.Gebruiker", b =>
                {
                    b.Property<int>("GebruikerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AchterNaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AdresId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfielNaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefoonnummer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VoorNaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wachtwoord")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GebruikerId");

                    b.HasIndex("AdresId");

                    b.ToTable("Gebruiker");
                });

            modelBuilder.Entity("MyMeals.Models.Maaltijd", b =>
                {
                    b.Property<int>("MaaltijdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AfbeeldingId")
                        .HasColumnType("int");

                    b.Property<int>("GebruikerId")
                        .HasColumnType("int");

                    b.Property<string>("Ingredienten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MyMealsUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Naam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Vegetarisch")
                        .HasColumnType("int");

                    b.HasKey("MaaltijdId");

                    b.HasIndex("GebruikerId");

                    b.HasIndex("MyMealsUserId");

                    b.ToTable("Maaltijd");
                });

            modelBuilder.Entity("MyMeals.Models.Post", b =>
                {
                    b.Property<int>("PostId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BereidOp")
                        .HasColumnType("datetime2");

                    b.Property<string>("Beschrijving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Bevroren")
                        .HasColumnType("int");

                    b.Property<int>("GebruikerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("HoudbaarTot")
                        .HasColumnType("datetime2");

                    b.Property<int>("MaaltijdId")
                        .HasColumnType("int");

                    b.Property<string>("MyMealsUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Porties")
                        .HasColumnType("int");

                    b.Property<string>("PostNaam")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("Prijs")
                        .HasColumnType("float");

                    b.HasKey("PostId");

                    b.HasIndex("GebruikerId");

                    b.HasIndex("MaaltijdId");

                    b.HasIndex("MyMealsUserId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MyMeals.Areas.Identity.Data.MyMealsUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MyMeals.Areas.Identity.Data.MyMealsUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyMeals.Areas.Identity.Data.MyMealsUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MyMeals.Areas.Identity.Data.MyMealsUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MyMeals.Areas.Identity.Data.MyMealsUser", b =>
                {
                    b.HasOne("MyMeals.Models.Adres", "Adres")
                        .WithMany()
                        .HasForeignKey("AdresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adres");
                });

            modelBuilder.Entity("MyMeals.Models.Gebruiker", b =>
                {
                    b.HasOne("MyMeals.Models.Adres", "Adres")
                        .WithMany("Gebruikers")
                        .HasForeignKey("AdresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Adres");
                });

            modelBuilder.Entity("MyMeals.Models.Maaltijd", b =>
                {
                    b.HasOne("MyMeals.Models.Gebruiker", "Gebruiker")
                        .WithMany("Maaltijds")
                        .HasForeignKey("GebruikerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyMeals.Areas.Identity.Data.MyMealsUser", null)
                        .WithMany("Maaltijds")
                        .HasForeignKey("MyMealsUserId");

                    b.Navigation("Gebruiker");
                });

            modelBuilder.Entity("MyMeals.Models.Post", b =>
                {
                    b.HasOne("MyMeals.Models.Gebruiker", "Gebruiker")
                        .WithMany("Posts")
                        .HasForeignKey("GebruikerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyMeals.Models.Maaltijd", "Maaltijd")
                        .WithMany("Posts")
                        .HasForeignKey("MaaltijdId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MyMeals.Areas.Identity.Data.MyMealsUser", null)
                        .WithMany("Posts")
                        .HasForeignKey("MyMealsUserId");

                    b.Navigation("Gebruiker");

                    b.Navigation("Maaltijd");
                });

            modelBuilder.Entity("MyMeals.Areas.Identity.Data.MyMealsUser", b =>
                {
                    b.Navigation("Maaltijds");

                    b.Navigation("Posts");
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
