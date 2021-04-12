using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyMeals.Migrations.MyMeals
{
    public partial class CombineUserData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AchterNaam",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AdresId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GebruikerId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProfielNaam",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefoonnummer",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VoorNaam",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Wachtwoord",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Adres",
                columns: table => new
                {
                    AdresId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Straat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Huisnummer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Woonplaats = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adres", x => x.AdresId);
                });

            migrationBuilder.CreateTable(
                name: "Gebruiker",
                columns: table => new
                {
                    GebruikerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VoorNaam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AchterNaam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfielNaam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wachtwoord = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdresId = table.Column<int>(type: "int", nullable: false),
                    Telefoonnummer = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gebruiker", x => x.GebruikerId);
                    table.ForeignKey(
                        name: "FK_Gebruiker_Adres_AdresId",
                        column: x => x.AdresId,
                        principalTable: "Adres",
                        principalColumn: "AdresId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Maaltijd",
                columns: table => new
                {
                    MaaltijdId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GebruikerId = table.Column<int>(type: "int", nullable: false),
                    Ingredienten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vegetarisch = table.Column<int>(type: "int", nullable: false),
                    AfbeeldingId = table.Column<int>(type: "int", nullable: false),
                    MyMealsUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maaltijd", x => x.MaaltijdId);
                    table.ForeignKey(
                        name: "FK_Maaltijd_AspNetUsers_MyMealsUserId",
                        column: x => x.MyMealsUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Maaltijd_Gebruiker_GebruikerId",
                        column: x => x.GebruikerId,
                        principalTable: "Gebruiker",
                        principalColumn: "GebruikerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Post",
                columns: table => new
                {
                    PostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PostNaam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GebruikerId = table.Column<int>(type: "int", nullable: false),
                    MaaltijdId = table.Column<int>(type: "int", nullable: false),
                    Bevroren = table.Column<int>(type: "int", nullable: false),
                    BereidOp = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoudbaarTot = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Porties = table.Column<int>(type: "int", nullable: false),
                    Prijs = table.Column<double>(type: "float", nullable: true),
                    Beschrijving = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MyMealsUserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Post", x => x.PostId);
                    table.ForeignKey(
                        name: "FK_Post_AspNetUsers_MyMealsUserId",
                        column: x => x.MyMealsUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Post_Gebruiker_GebruikerId",
                        column: x => x.GebruikerId,
                        principalTable: "Gebruiker",
                        principalColumn: "GebruikerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Post_Maaltijd_MaaltijdId",
                        column: x => x.MaaltijdId,
                        principalTable: "Maaltijd",
                        principalColumn: "MaaltijdId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_AdresId",
                table: "AspNetUsers",
                column: "AdresId");

            migrationBuilder.CreateIndex(
                name: "IX_Gebruiker_AdresId",
                table: "Gebruiker",
                column: "AdresId");

            migrationBuilder.CreateIndex(
                name: "IX_Maaltijd_GebruikerId",
                table: "Maaltijd",
                column: "GebruikerId");

            migrationBuilder.CreateIndex(
                name: "IX_Maaltijd_MyMealsUserId",
                table: "Maaltijd",
                column: "MyMealsUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_GebruikerId",
                table: "Post",
                column: "GebruikerId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_MaaltijdId",
                table: "Post",
                column: "MaaltijdId");

            migrationBuilder.CreateIndex(
                name: "IX_Post_MyMealsUserId",
                table: "Post",
                column: "MyMealsUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Adres_AdresId",
                table: "AspNetUsers",
                column: "AdresId",
                principalTable: "Adres",
                principalColumn: "AdresId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Adres_AdresId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Post");

            migrationBuilder.DropTable(
                name: "Maaltijd");

            migrationBuilder.DropTable(
                name: "Gebruiker");

            migrationBuilder.DropTable(
                name: "Adres");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_AdresId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AchterNaam",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AdresId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GebruikerId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfielNaam",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Telefoonnummer",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "VoorNaam",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Wachtwoord",
                table: "AspNetUsers");
        }
    }
}
