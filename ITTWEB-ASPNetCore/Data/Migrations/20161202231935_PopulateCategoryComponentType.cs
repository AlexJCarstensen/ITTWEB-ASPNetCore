using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITTWEB_ASPNetCore.Data.Migrations
{
    public partial class PopulateCategoryComponentType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO CategoryComponentTypes (CategoryId, ComponentTypeId) VALUES (1, 1)");
            migrationBuilder.Sql("INSERT INTO CategoryComponentTypes (CategoryId, ComponentTypeId) VALUES (2, 2)");
            migrationBuilder.Sql("INSERT INTO CategoryComponentTypes (CategoryId, ComponentTypeId) VALUES (2, 3)");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
