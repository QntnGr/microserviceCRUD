﻿using microserviceCRUD.Entities;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace microserviceCRUD.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CatalogItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    PictureUri = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatalogItems", x => x.Id);
                });
            AddDummyData(migrationBuilder);
        }

        private void AddDummyData(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData("CatalogItems",
                columns: new string[]
                {
                    "Name",
                    "Description",
                    "Price",
                    "PictureUri",
                    "Room"
                }
                ,
                values:
                    new object[]
                    {
                        "ab",
                        "produit ab",
                        2m,
                        "/",
                        new object[]
                        {
                            1,
                            "main room"
                        }
                    }
            );
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatalogItems");
        }
    }
}
