using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITTWEB_ASPNetCore.Data.Migrations
{
    public partial class PopulateCategory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Catagories (Name) VALUES ('Lys')");
            migrationBuilder.Sql("INSERT INTO Catagories (Name) VALUES ('Bluetooth')");
            migrationBuilder.Sql("INSERT INTO Catagories (Name) VALUES ('Trådløst')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
