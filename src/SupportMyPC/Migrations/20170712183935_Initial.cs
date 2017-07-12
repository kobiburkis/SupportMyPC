using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SupportMyPC.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "supportCalls",
                columns: table => new
                {
                    SupportCallId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CustEmail = table.Column<string>(nullable: true),
                    CustID = table.Column<string>(nullable: true),
                    CustName = table.Column<string>(nullable: false),
                    CustPhone = table.Column<string>(nullable: false),
                    ProblemDescription = table.Column<string>(nullable: true),
                    ProblemMachine = table.Column<string>(nullable: true),
                    ProblemMachineID = table.Column<int>(nullable: false),
                    RegisteredCust = table.Column<bool>(nullable: true),
                    SupportCallDate = table.Column<string>(nullable: true),
                    SupportCallStatus = table.Column<string>(nullable: true),
                    SupportCallStatusID = table.Column<int>(nullable: false),
                    SupportCallTreatDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supportCalls", x => x.SupportCallId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "supportCalls");
        }
    }
}
