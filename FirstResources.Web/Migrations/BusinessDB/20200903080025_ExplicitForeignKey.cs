using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstResources.Web.Migrations.BusinessDB
{
    public partial class ExplicitForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataKaryawan_Agama_AgamaId",
                table: "DataKaryawan");

            migrationBuilder.DropForeignKey(
                name: "FK_DataKaryawan_Departemen_DepartemenId",
                table: "DataKaryawan");

            migrationBuilder.DropForeignKey(
                name: "FK_DataKaryawan_Jabatan_JabatanId",
                table: "DataKaryawan");

            migrationBuilder.DropForeignKey(
                name: "FK_DataKaryawan_JenisKelamin_JenisKelaminId",
                table: "DataKaryawan");

            migrationBuilder.AlterColumn<int>(
                name: "JenisKelaminId",
                table: "DataKaryawan",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "JabatanId",
                table: "DataKaryawan",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DepartemenId",
                table: "DataKaryawan",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AgamaId",
                table: "DataKaryawan",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DataKaryawan_Agama_AgamaId",
                table: "DataKaryawan",
                column: "AgamaId",
                principalTable: "Agama",
                principalColumn: "AgamaId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DataKaryawan_Departemen_DepartemenId",
                table: "DataKaryawan",
                column: "DepartemenId",
                principalTable: "Departemen",
                principalColumn: "DepartemenId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DataKaryawan_Jabatan_JabatanId",
                table: "DataKaryawan",
                column: "JabatanId",
                principalTable: "Jabatan",
                principalColumn: "JabatanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DataKaryawan_JenisKelamin_JenisKelaminId",
                table: "DataKaryawan",
                column: "JenisKelaminId",
                principalTable: "JenisKelamin",
                principalColumn: "JenisKelaminId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataKaryawan_Agama_AgamaId",
                table: "DataKaryawan");

            migrationBuilder.DropForeignKey(
                name: "FK_DataKaryawan_Departemen_DepartemenId",
                table: "DataKaryawan");

            migrationBuilder.DropForeignKey(
                name: "FK_DataKaryawan_Jabatan_JabatanId",
                table: "DataKaryawan");

            migrationBuilder.DropForeignKey(
                name: "FK_DataKaryawan_JenisKelamin_JenisKelaminId",
                table: "DataKaryawan");

            migrationBuilder.AlterColumn<int>(
                name: "JenisKelaminId",
                table: "DataKaryawan",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "JabatanId",
                table: "DataKaryawan",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "DepartemenId",
                table: "DataKaryawan",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "AgamaId",
                table: "DataKaryawan",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_DataKaryawan_Agama_AgamaId",
                table: "DataKaryawan",
                column: "AgamaId",
                principalTable: "Agama",
                principalColumn: "AgamaId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DataKaryawan_Departemen_DepartemenId",
                table: "DataKaryawan",
                column: "DepartemenId",
                principalTable: "Departemen",
                principalColumn: "DepartemenId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DataKaryawan_Jabatan_JabatanId",
                table: "DataKaryawan",
                column: "JabatanId",
                principalTable: "Jabatan",
                principalColumn: "JabatanId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DataKaryawan_JenisKelamin_JenisKelaminId",
                table: "DataKaryawan",
                column: "JenisKelaminId",
                principalTable: "JenisKelamin",
                principalColumn: "JenisKelaminId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
