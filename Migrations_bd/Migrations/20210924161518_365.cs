using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using System;

namespace Migrations_bd.Migrations
{
    public partial class _365 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "gar_AddObjCon",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OBJECTID = table.Column<long>(type: "bigint", nullable: false),
                    OBJECTGUID = table.Column<string>(type: "text", nullable: true),
                    CHANGEID = table.Column<long>(type: "bigint", nullable: false),
                    NAME = table.Column<string>(type: "text", nullable: true),
                    TYPENAME = table.Column<string>(type: "text", nullable: true),
                    LEVEL = table.Column<string>(type: "text", nullable: true),
                    OPERTYPEID = table.Column<string>(type: "text", nullable: true),
                    PREVID = table.Column<long>(type: "bigint", nullable: false),
                    NEXTID = table.Column<long>(type: "bigint", nullable: false),
                    UPDATEDATE = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    STARTDATE = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ENDDATE = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    ISACTUAL = table.Column<int>(type: "integer", nullable: false),
                    ISACTIVE = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gar_AddObjCon", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "gar_AdmHierCon",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    oBJECTID = table.Column<long>(type: "bigint", nullable: false),
                    pARENTOBJID = table.Column<long>(type: "bigint", nullable: false),
                    cHANGEID = table.Column<long>(type: "bigint", nullable: false),
                    rEGIONCODE = table.Column<string>(type: "text", nullable: true),
                    aREACODE = table.Column<string>(type: "text", nullable: true),
                    cITYCODE = table.Column<string>(type: "text", nullable: true),
                    pLACECODE = table.Column<string>(type: "text", nullable: true),
                    pLANCODE = table.Column<string>(type: "text", nullable: true),
                    sTREETCODE = table.Column<string>(type: "text", nullable: true),
                    pREVID = table.Column<long>(type: "bigint", nullable: false),
                    nEXTID = table.Column<long>(type: "bigint", nullable: false),
                    uPDATEDATE = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    sTARTDATE = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    eNDDATE = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    iSACTIVE = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gar_AdmHierCon", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "gar_HousesCon",
                columns: table => new
                {
                    id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    oBJECTID = table.Column<long>(type: "bigint", nullable: false),
                    oBJECTGUID = table.Column<string>(type: "text", nullable: true),
                    cHANGEID = table.Column<long>(type: "bigint", nullable: false),
                    hOUSENUM = table.Column<string>(type: "text", nullable: true),
                    aDDNUM1 = table.Column<string>(type: "text", nullable: true),
                    aDDNUM2 = table.Column<string>(type: "text", nullable: true),
                    hOUSETYPE = table.Column<string>(type: "text", nullable: true),
                    aDDTYPE1 = table.Column<string>(type: "text", nullable: true),
                    aDDTYPE2 = table.Column<string>(type: "text", nullable: true),
                    oPERTYPEID = table.Column<string>(type: "text", nullable: true),
                    pREVID = table.Column<long>(type: "bigint", nullable: false),
                    nEXTID = table.Column<long>(type: "bigint", nullable: false),
                    uPDATEDATE = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    sTARTDATE = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    eNDDATE = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    iSACTUAL = table.Column<int>(type: "integer", nullable: false),
                    iSACTIVE = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gar_HousesCon", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "gar_AddObjCon");

            migrationBuilder.DropTable(
                name: "gar_AdmHierCon");

            migrationBuilder.DropTable(
                name: "gar_HousesCon");
        }
    }
}
