using Microsoft.EntityFrameworkCore.Migrations;

namespace Migrations_bd.Migrations
{
    public partial class _456 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "uPDATEDATE",
                table: "gar_HousesCon",
                newName: "UPDATEDATE");

            migrationBuilder.RenameColumn(
                name: "sTARTDATE",
                table: "gar_HousesCon",
                newName: "STARTDATE");

            migrationBuilder.RenameColumn(
                name: "pREVID",
                table: "gar_HousesCon",
                newName: "PREVID");

            migrationBuilder.RenameColumn(
                name: "oPERTYPEID",
                table: "gar_HousesCon",
                newName: "OPERTYPEID");

            migrationBuilder.RenameColumn(
                name: "oBJECTID",
                table: "gar_HousesCon",
                newName: "OBJECTID");

            migrationBuilder.RenameColumn(
                name: "oBJECTGUID",
                table: "gar_HousesCon",
                newName: "OBJECTGUID");

            migrationBuilder.RenameColumn(
                name: "nEXTID",
                table: "gar_HousesCon",
                newName: "NEXTID");

            migrationBuilder.RenameColumn(
                name: "iSACTUAL",
                table: "gar_HousesCon",
                newName: "ISACTUAL");

            migrationBuilder.RenameColumn(
                name: "iSACTIVE",
                table: "gar_HousesCon",
                newName: "ISACTIVE");

            migrationBuilder.RenameColumn(
                name: "hOUSETYPE",
                table: "gar_HousesCon",
                newName: "HOUSETYPE");

            migrationBuilder.RenameColumn(
                name: "hOUSENUM",
                table: "gar_HousesCon",
                newName: "HOUSENUM");

            migrationBuilder.RenameColumn(
                name: "eNDDATE",
                table: "gar_HousesCon",
                newName: "ENDDATE");

            migrationBuilder.RenameColumn(
                name: "cHANGEID",
                table: "gar_HousesCon",
                newName: "CHANGEID");

            migrationBuilder.RenameColumn(
                name: "aDDTYPE2",
                table: "gar_HousesCon",
                newName: "ADDTYPE2");

            migrationBuilder.RenameColumn(
                name: "aDDTYPE1",
                table: "gar_HousesCon",
                newName: "ADDTYPE1");

            migrationBuilder.RenameColumn(
                name: "aDDNUM2",
                table: "gar_HousesCon",
                newName: "ADDNUM2");

            migrationBuilder.RenameColumn(
                name: "aDDNUM1",
                table: "gar_HousesCon",
                newName: "ADDNUM1");

            migrationBuilder.RenameColumn(
                name: "uPDATEDATE",
                table: "gar_AdmHierCon",
                newName: "UPDATEDATE");

            migrationBuilder.RenameColumn(
                name: "sTREETCODE",
                table: "gar_AdmHierCon",
                newName: "STREETCODE");

            migrationBuilder.RenameColumn(
                name: "sTARTDATE",
                table: "gar_AdmHierCon",
                newName: "STARTDATE");

            migrationBuilder.RenameColumn(
                name: "rEGIONCODE",
                table: "gar_AdmHierCon",
                newName: "REGIONCODE");

            migrationBuilder.RenameColumn(
                name: "pREVID",
                table: "gar_AdmHierCon",
                newName: "PREVID");

            migrationBuilder.RenameColumn(
                name: "pLANCODE",
                table: "gar_AdmHierCon",
                newName: "PLANCODE");

            migrationBuilder.RenameColumn(
                name: "pLACECODE",
                table: "gar_AdmHierCon",
                newName: "PLACECODE");

            migrationBuilder.RenameColumn(
                name: "pARENTOBJID",
                table: "gar_AdmHierCon",
                newName: "PARENTOBJID");

            migrationBuilder.RenameColumn(
                name: "oBJECTID",
                table: "gar_AdmHierCon",
                newName: "OBJECTID");

            migrationBuilder.RenameColumn(
                name: "nEXTID",
                table: "gar_AdmHierCon",
                newName: "NEXTID");

            migrationBuilder.RenameColumn(
                name: "iSACTIVE",
                table: "gar_AdmHierCon",
                newName: "ISACTIVE");

            migrationBuilder.RenameColumn(
                name: "eNDDATE",
                table: "gar_AdmHierCon",
                newName: "ENDDATE");

            migrationBuilder.RenameColumn(
                name: "cITYCODE",
                table: "gar_AdmHierCon",
                newName: "CITYCODE");

            migrationBuilder.RenameColumn(
                name: "cHANGEID",
                table: "gar_AdmHierCon",
                newName: "CHANGEID");

            migrationBuilder.RenameColumn(
                name: "aREACODE",
                table: "gar_AdmHierCon",
                newName: "AREACODE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UPDATEDATE",
                table: "gar_HousesCon",
                newName: "uPDATEDATE");

            migrationBuilder.RenameColumn(
                name: "STARTDATE",
                table: "gar_HousesCon",
                newName: "sTARTDATE");

            migrationBuilder.RenameColumn(
                name: "PREVID",
                table: "gar_HousesCon",
                newName: "pREVID");

            migrationBuilder.RenameColumn(
                name: "OPERTYPEID",
                table: "gar_HousesCon",
                newName: "oPERTYPEID");

            migrationBuilder.RenameColumn(
                name: "OBJECTID",
                table: "gar_HousesCon",
                newName: "oBJECTID");

            migrationBuilder.RenameColumn(
                name: "OBJECTGUID",
                table: "gar_HousesCon",
                newName: "oBJECTGUID");

            migrationBuilder.RenameColumn(
                name: "NEXTID",
                table: "gar_HousesCon",
                newName: "nEXTID");

            migrationBuilder.RenameColumn(
                name: "ISACTUAL",
                table: "gar_HousesCon",
                newName: "iSACTUAL");

            migrationBuilder.RenameColumn(
                name: "ISACTIVE",
                table: "gar_HousesCon",
                newName: "iSACTIVE");

            migrationBuilder.RenameColumn(
                name: "HOUSETYPE",
                table: "gar_HousesCon",
                newName: "hOUSETYPE");

            migrationBuilder.RenameColumn(
                name: "HOUSENUM",
                table: "gar_HousesCon",
                newName: "hOUSENUM");

            migrationBuilder.RenameColumn(
                name: "ENDDATE",
                table: "gar_HousesCon",
                newName: "eNDDATE");

            migrationBuilder.RenameColumn(
                name: "CHANGEID",
                table: "gar_HousesCon",
                newName: "cHANGEID");

            migrationBuilder.RenameColumn(
                name: "ADDTYPE2",
                table: "gar_HousesCon",
                newName: "aDDTYPE2");

            migrationBuilder.RenameColumn(
                name: "ADDTYPE1",
                table: "gar_HousesCon",
                newName: "aDDTYPE1");

            migrationBuilder.RenameColumn(
                name: "ADDNUM2",
                table: "gar_HousesCon",
                newName: "aDDNUM2");

            migrationBuilder.RenameColumn(
                name: "ADDNUM1",
                table: "gar_HousesCon",
                newName: "aDDNUM1");

            migrationBuilder.RenameColumn(
                name: "UPDATEDATE",
                table: "gar_AdmHierCon",
                newName: "uPDATEDATE");

            migrationBuilder.RenameColumn(
                name: "STREETCODE",
                table: "gar_AdmHierCon",
                newName: "sTREETCODE");

            migrationBuilder.RenameColumn(
                name: "STARTDATE",
                table: "gar_AdmHierCon",
                newName: "sTARTDATE");

            migrationBuilder.RenameColumn(
                name: "REGIONCODE",
                table: "gar_AdmHierCon",
                newName: "rEGIONCODE");

            migrationBuilder.RenameColumn(
                name: "PREVID",
                table: "gar_AdmHierCon",
                newName: "pREVID");

            migrationBuilder.RenameColumn(
                name: "PLANCODE",
                table: "gar_AdmHierCon",
                newName: "pLANCODE");

            migrationBuilder.RenameColumn(
                name: "PLACECODE",
                table: "gar_AdmHierCon",
                newName: "pLACECODE");

            migrationBuilder.RenameColumn(
                name: "PARENTOBJID",
                table: "gar_AdmHierCon",
                newName: "pARENTOBJID");

            migrationBuilder.RenameColumn(
                name: "OBJECTID",
                table: "gar_AdmHierCon",
                newName: "oBJECTID");

            migrationBuilder.RenameColumn(
                name: "NEXTID",
                table: "gar_AdmHierCon",
                newName: "nEXTID");

            migrationBuilder.RenameColumn(
                name: "ISACTIVE",
                table: "gar_AdmHierCon",
                newName: "iSACTIVE");

            migrationBuilder.RenameColumn(
                name: "ENDDATE",
                table: "gar_AdmHierCon",
                newName: "eNDDATE");

            migrationBuilder.RenameColumn(
                name: "CITYCODE",
                table: "gar_AdmHierCon",
                newName: "cITYCODE");

            migrationBuilder.RenameColumn(
                name: "CHANGEID",
                table: "gar_AdmHierCon",
                newName: "cHANGEID");

            migrationBuilder.RenameColumn(
                name: "AREACODE",
                table: "gar_AdmHierCon",
                newName: "aREACODE");
        }
    }
}
