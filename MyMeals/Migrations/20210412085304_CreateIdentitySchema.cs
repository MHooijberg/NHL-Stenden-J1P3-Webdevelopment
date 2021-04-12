using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMeals.Migrations
{
    public partial class CreateIdentitySchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Adres",
                columns: table => new
                {
                    AdresID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Straat = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Huisnummer = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Postcode = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Woonplaats = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Adres__DA8DEA6CB75AD8A2", x => x.AdresID);
                });

            migrationBuilder.CreateTable(
                name: "Gebruiker",
                columns: table => new
                {
                    GebruikerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoorNaam = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    AchterNaam = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    ProfielNaam = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Wachtwoord = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    AdresID = table.Column<int>(type: "int", nullable: false),
                    Telefoonnummer = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruiker", x => x.GebruikerID);
                    table.ForeignKey(
                        name: "FK__Gebruiker__Adres__38996AB5",
                        column: x => x.AdresID,
                        principalTable: "Adres",
                        principalColumn: "AdresID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Maaltijd",
                columns: table => new
                {
                    MaaltijdID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    GebruikerID = table.Column<int>(type: "int", nullable: false),
                    Ingredienten = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Vegetarisch = table.Column<int>(type: "int", nullable: false),
                    AfbeeldingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maaltijd", x => x.MaaltijdID);
                    table.ForeignKey(
                        name: "FK__Maaltijd__Gebrui__3B75D760",
                        column: x => x.GebruikerID,
                        principalTable: "Gebruiker",
                        principalColumn: "GebruikerID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    PostID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostNaam = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    GebruikerID = table.Column<int>(type: "int", nullable: false),
                    MaaltijdID = table.Column<int>(type: "int", nullable: false),
                    Bevroren = table.Column<int>(type: "int", nullable: false),
                    BereidOp = table.Column<DateTime>(type: "date", nullable: false),
                    HoudbaarTot = table.Column<DateTime>(type: "date", nullable: false),
                    Porties = table.Column<int>(type: "int", nullable: false),
                    Prijs = table.Column<double>(type: "float", nullable: true),
                    Beschrijving = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.PostID);
                    table.ForeignKey(
                        name: "FK__Post__GebruikerI__3E52440B",
                        column: x => x.GebruikerID,
                        principalTable: "Gebruiker",
                        principalColumn: "GebruikerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Post__MaaltijdID__3F466844",
                        column: x => x.MaaltijdID,
                        principalTable: "Maaltijd",
                        principalColumn: "MaaltijdID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gebruiker_AdresID",
                table: "Gebruiker",
                column: "AdresID");

            migrationBuilder.CreateIndex(
                name: "IX_Maaltijd_GebruikerID",
                table: "Maaltijd",
                column: "GebruikerID");

            migrationBuilder.CreateIndex(
                name: "IX_Post_GebruikerID",
                table: "Post",
                column: "GebruikerID");

            migrationBuilder.CreateIndex(
                name: "IX_Post_MaaltijdID",
                table: "Post",
                column: "MaaltijdID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Maaltijd");

            migrationBuilder.DropTable(
                name: "Gebruiker");

            migrationBuilder.DropTable(
                name: "Adres");
        }
    }
}
