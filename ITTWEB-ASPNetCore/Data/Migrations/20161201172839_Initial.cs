using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ITTWEB_ASPNetCore.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
           

           

           

           

            migrationBuilder.CreateTable(
                name: "Catagories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catagories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "EsImages",
                columns: table => new
                {
                    ESImageId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ImageData = table.Column<byte[]>(nullable: true),
                    ImageMimeType = table.Column<string>(maxLength: 128, nullable: true),
                    Thumbnail = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EsImages", x => x.ESImageId);
                });

            migrationBuilder.CreateTable(
                name: "ComponentTypes",
                columns: table => new
                {
                    ComponentTypeId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdminComment = table.Column<string>(nullable: true),
                    ComponentInfo = table.Column<string>(nullable: true),
                    ComponentName = table.Column<string>(nullable: true),
                    Datasheet = table.Column<string>(nullable: true),
                    ImageESImageId = table.Column<long>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    Manufacturer = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    WikiLink = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComponentTypes", x => x.ComponentTypeId);
                    table.ForeignKey(
                        name: "FK_ComponentTypes_EsImages_ImageESImageId",
                        column: x => x.ImageESImageId,
                        principalTable: "EsImages",
                        principalColumn: "ESImageId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Components",
                columns: table => new
                {
                    ComponentId = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AdminComment = table.Column<string>(nullable: true),
                    ComponentNumber = table.Column<int>(nullable: false),
                    ComponentTypeId = table.Column<long>(nullable: false),
                    CurrentLoanInformationId = table.Column<long>(nullable: true),
                    SerialNo = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    UserComment = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Components", x => x.ComponentId);
                    table.ForeignKey(
                        name: "FK_Components_ComponentTypes_ComponentTypeId",
                        column: x => x.ComponentTypeId,
                        principalTable: "ComponentTypes",
                        principalColumn: "ComponentTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CategoryComponentTypes",
                columns: table => new
                {
                    CategoryComponentTypeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CategoryId = table.Column<int>(nullable: false),
                    ComponentTypeId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryComponentTypes", x => x.CategoryComponentTypeId);
                    table.ForeignKey(
                        name: "FK_CategoryComponentTypes_Catagories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Catagories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryComponentTypes_ComponentTypes_ComponentTypeId",
                        column: x => x.ComponentTypeId,
                        principalTable: "ComponentTypes",
                        principalColumn: "ComponentTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

           

           

            migrationBuilder.CreateIndex(
                name: "IX_Components_ComponentTypeId",
                table: "Components",
                column: "ComponentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ComponentTypes_ImageESImageId",
                table: "ComponentTypes",
                column: "ImageESImageId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryComponentTypes_CategoryId",
                table: "CategoryComponentTypes",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryComponentTypes_ComponentTypeId",
                table: "CategoryComponentTypes",
                column: "ComponentTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Components");

            migrationBuilder.DropTable(
                name: "CategoryComponentTypes");

            migrationBuilder.DropTable(
                name: "Catagories");

            migrationBuilder.DropTable(
                name: "ComponentTypes");

            migrationBuilder.DropTable(
                name: "EsImages");

            

            

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AspNetUserClaims",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "AspNetRoleClaims",
                nullable: false,
                oldClrType: typeof(int))
                .OldAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

           

           
        }
    }
}
