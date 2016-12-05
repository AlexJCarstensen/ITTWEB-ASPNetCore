using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITTWEBASPNetCore.Migrations
{
    public partial class populateCategories : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categories (Name) VALUES ('Lys')");
            migrationBuilder.Sql("INSERT INTO Categories (Name) VALUES ('Bluetooth')");
            migrationBuilder.Sql("INSERT INTO Categories (Name) VALUES ('Trådløst')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
