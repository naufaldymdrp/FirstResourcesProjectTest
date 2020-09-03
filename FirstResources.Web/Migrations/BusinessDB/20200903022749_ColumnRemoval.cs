using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstResources.Web.Migrations.BusinessDB
{
    public partial class ColumnRemoval : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agama_DataKaryawan_DataKaryawanId",
                table: "Agama");

            migrationBuilder.DropForeignKey(
                name: "FK_Departemen_DataKaryawan_DataKaryawanId",
                table: "Departemen");

            migrationBuilder.DropForeignKey(
                name: "FK_Jabatan_DataKaryawan_DataKaryawanId",
                table: "Jabatan");

            migrationBuilder.DropForeignKey(
                name: "FK_JenisKelamin_DataKaryawan_DataKaryawanId",
                table: "JenisKelamin");

            migrationBuilder.AlterColumn<int>(
                name: "DataKaryawanId",
                table: "JenisKelamin",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DataKaryawanId",
                table: "Jabatan",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DataKaryawanId",
                table: "Departemen",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<int>(
                name: "DataKaryawanId",
                table: "Agama",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Agama_DataKaryawan_DataKaryawanId",
                table: "Agama",
                column: "DataKaryawanId",
                principalTable: "DataKaryawan",
                principalColumn: "DataKaryawanId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Departemen_DataKaryawan_DataKaryawanId",
                table: "Departemen",
                column: "DataKaryawanId",
                principalTable: "DataKaryawan",
                principalColumn: "DataKaryawanId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Jabatan_DataKaryawan_DataKaryawanId",
                table: "Jabatan",
                column: "DataKaryawanId",
                principalTable: "DataKaryawan",
                principalColumn: "DataKaryawanId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_JenisKelamin_DataKaryawan_DataKaryawanId",
                table: "JenisKelamin",
                column: "DataKaryawanId",
                principalTable: "DataKaryawan",
                principalColumn: "DataKaryawanId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agama_DataKaryawan_DataKaryawanId",
                table: "Agama");

            migrationBuilder.DropForeignKey(
                name: "FK_Departemen_DataKaryawan_DataKaryawanId",
                table: "Departemen");

            migrationBuilder.DropForeignKey(
                name: "FK_Jabatan_DataKaryawan_DataKaryawanId",
                table: "Jabatan");

            migrationBuilder.DropForeignKey(
                name: "FK_JenisKelamin_DataKaryawan_DataKaryawanId",
                table: "JenisKelamin");

            migrationBuilder.AlterColumn<int>(
                name: "DataKaryawanId",
                table: "JenisKelamin",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DataKaryawanId",
                table: "Jabatan",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DataKaryawanId",
                table: "Departemen",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DataKaryawanId",
                table: "Agama",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Agama_DataKaryawan_DataKaryawanId",
                table: "Agama",
                column: "DataKaryawanId",
                principalTable: "DataKaryawan",
                principalColumn: "DataKaryawanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departemen_DataKaryawan_DataKaryawanId",
                table: "Departemen",
                column: "DataKaryawanId",
                principalTable: "DataKaryawan",
                principalColumn: "DataKaryawanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Jabatan_DataKaryawan_DataKaryawanId",
                table: "Jabatan",
                column: "DataKaryawanId",
                principalTable: "DataKaryawan",
                principalColumn: "DataKaryawanId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JenisKelamin_DataKaryawan_DataKaryawanId",
                table: "JenisKelamin",
                column: "DataKaryawanId",
                principalTable: "DataKaryawan",
                principalColumn: "DataKaryawanId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
