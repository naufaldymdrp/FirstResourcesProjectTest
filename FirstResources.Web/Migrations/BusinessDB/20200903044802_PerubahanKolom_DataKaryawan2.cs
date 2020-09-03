using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstResources.Web.Migrations.BusinessDB
{
    public partial class PerubahanKolom_DataKaryawan2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "TanggalLahir",
                table: "DataKaryawan",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TanggalLahir",
                table: "DataKaryawan");
        }
    }
}
