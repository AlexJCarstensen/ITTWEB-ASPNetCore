using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ITTWEBASPNetCore.Migrations
{
    public partial class PopulateComponents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Components (AdminComment, ComponentNumber, ComponentTypeId, CurrentLoanInformationId, SerialNo, Status, UserComment) " +
                                 "VALUES ('This component is da shit', " +
                                 "1, " +
                                 "1, " +
                                 "1, " +
                                 "222555888, " +
                                 "1, " +
                                 "'Never will I use this again')");

            migrationBuilder.Sql("INSERT INTO Components (AdminComment, ComponentNumber, ComponentTypeId, CurrentLoanInformationId, SerialNo, Status, UserComment) " +
                                 "VALUES ('This component is da shit', " +
                                 "2, " +
                                 "1, " +
                                 "1, " +
                                 "222555888, " +
                                 "1, " +
                                 "'Never will I use this again')");

            migrationBuilder.Sql("INSERT INTO Components (AdminComment, ComponentNumber, ComponentTypeId, CurrentLoanInformationId, SerialNo, Status, UserComment) " +
                                 "VALUES ('This component is da shit', " +
                                 "2, " +
                                 "1, " +
                                 "1, " +
                                 "222555888, " +
                                 "1, " +
                                 "'Never will I use this again')");

            //ComponentType 2
            migrationBuilder.Sql("INSERT INTO Components (AdminComment, ComponentNumber, ComponentTypeId, CurrentLoanInformationId, SerialNo, Status, UserComment) " +
                                 "VALUES ('This component is da shit', " +
                                 "1, " +
                                 "2, " +
                                 "1, " +
                                 "222555888, " +
                                 "1, " +
                                 "'Never will I use this again')");

            migrationBuilder.Sql("INSERT INTO Components (AdminComment, ComponentNumber, ComponentTypeId, CurrentLoanInformationId, SerialNo, Status, UserComment) " +
                                 "VALUES ('This component is da shit', " +
                                 "2, " +
                                 "2, " +
                                 "1, " +
                                 "222555888, " +
                                 "1, " +
                                 "'Never will I use this again')");

            migrationBuilder.Sql("INSERT INTO Components (AdminComment, ComponentNumber, ComponentTypeId, CurrentLoanInformationId, SerialNo, Status, UserComment) " +
                                 "VALUES ('This component is da shit', " +
                                 "3, " +
                                 "2, " +
                                 "1, " +
                                 "222555888, " +
                                 "1, " +
                                 "'Never will I use this again')");

            //ComponentType 3
            migrationBuilder.Sql("INSERT INTO Components (AdminComment, ComponentNumber, ComponentTypeId, CurrentLoanInformationId, SerialNo, Status, UserComment) " +
                                 "VALUES ('This component is da shit', " +
                                 "1, " +
                                 "3, " +
                                 "1, " +
                                 "222555888, " +
                                 "1, " +
                                 "'Never will I use this again')");

            migrationBuilder.Sql("INSERT INTO Components (AdminComment, ComponentNumber, ComponentTypeId, CurrentLoanInformationId, SerialNo, Status, UserComment) " +
                                 "VALUES ('This component is da shit', " +
                                 "2, " +
                                 "3, " +
                                 "1, " +
                                 "222555888, " +
                                 "1, " +
                                 "'Never will I use this again')");

            migrationBuilder.Sql("INSERT INTO Components (AdminComment, ComponentNumber, ComponentTypeId, CurrentLoanInformationId, SerialNo, Status, UserComment) " +
                                 "VALUES ('This component is da shit', " +
                                 "3, " +
                                 "3, " +
                                 "1, " +
                                 "222555888, " +
                                 "1, " +
                                 "'Never will I use this again')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
