using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITTWEB_ASPNetCore.Data.Migrations
{
    public partial class addmigrationPopulateComponentType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //ComponentTypes
            migrationBuilder.Sql(
                "INSERT INTO ComponentTypes (ComponentName, ComponentInfo, Location, Status, Datasheet, ImageUrl, Manufacturer, WikiLink, AdminComment) " +
                "VALUES ('LED cube 3x3x3', " +
                "'This is a kit for a 3x3x3 cube of RGB LEDs. This kit contains everything you’ll need - 27 LEDs, an ATmega328 microcontroller, a custom PCB, and other supporting components.', " +
                "'Komponentlageret', " +
                "1, " +
                "'http://10.29.0.30/EmbeddedStock/?category=LED', " +
                "'Image url test', " +
                "'Siemens', " +
                "'https://steelseries.com/', " +
                "'Det virker bare mega godt!')");

            migrationBuilder.Sql(
               "INSERT INTO ComponentTypes (ComponentName, ComponentInfo, Location, Status, Datasheet, ImageUrl, Manufacturer, WikiLink, AdminComment) " +
               "VALUES ('Bluetooth RS232 Adapter', " +
               "'RS232 to Bloetooth adapter.', " +
               "'Komponentlageret', " +
               "1, " +
               "'http://10.29.0.30/EmbeddedStock/?category=LED', " +
               "'Image url test', " +
               "'Siemens', " +
               "'https://steelseries.com/', " +
               "'Det virker bare mega godt!')");

            migrationBuilder.Sql(
               "INSERT INTO ComponentTypes (ComponentName, ComponentInfo, Location, Status, Datasheet, ImageUrl, Manufacturer, WikiLink, AdminComment) " +
               "VALUES ('RN42 Bluetooth Evaluation Kit', " +
               "'The RN42 is a small form factor, low power, Class 2 Bluetooth radio for designers who want to add wireless capability to their products. The RN42 supports multiple interface protocols, is simple to design in, and is fully certified, making it a complete embedded Bluetooth solution. The RN42 is functionally compatible with the RN41. With its high-performance PCB trace antenna and support for Bluetooth EDR, the RN42 delivers up to 3 Mbps data rate for distances up to 20 meters.', " +
               "'Komponentlageret', " +
               "1, " +
               "'http://10.29.0.30/EmbeddedStock/?category=LED', " +
               "'Image url test', " +
               "'Siemens', " +
               "'https://steelseries.com/', " +
               "'Det virker bare mega godt!')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
