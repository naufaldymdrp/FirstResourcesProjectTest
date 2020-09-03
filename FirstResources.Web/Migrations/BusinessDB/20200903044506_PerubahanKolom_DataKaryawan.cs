using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstResources.Web.Migrations.BusinessDB
{
    public partial class PerubahanKolom_DataKaryawan : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TanggalLahir",
                table: "DataKaryawan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TanggalLahir",
                table: "DataKaryawan",
                type: "text",
                nullable: true);
        }
    }
}
