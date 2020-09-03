using Microsoft.EntityFrameworkCore.Migrations;

namespace FirstResources.Web.Migrations.BusinessDB
{
    public partial class BusinessLogicUpdate : Migration
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

            migrationBuilder.DropIndex(
                name: "IX_JenisKelamin_DataKaryawanId",
                table: "JenisKelamin");

            migrationBuilder.DropIndex(
                name: "IX_Jabatan_DataKaryawanId",
                table: "Jabatan");

            migrationBuilder.DropIndex(
                name: "IX_Departemen_DataKaryawanId",
                table: "Departemen");

            migrationBuilder.DropIndex(
                name: "IX_Agama_DataKaryawanId",
                table: "Agama");

            migrationBuilder.DropColumn(
                name: "DataKaryawanId",
                table: "JenisKelamin");

            migrationBuilder.DropColumn(
                name: "DataKaryawanId",
                table: "Jabatan");

            migrationBuilder.DropColumn(
                name: "DataKaryawanId",
                table: "Departemen");

            migrationBuilder.DropColumn(
                name: "DataKaryawanId",
                table: "Agama");

            migrationBuilder.AddColumn<int>(
                name: "AgamaId",
                table: "DataKaryawan",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DepartemenId",
                table: "DataKaryawan",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JabatanId",
                table: "DataKaryawan",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JenisKelaminId",
                table: "DataKaryawan",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DataKaryawan_AgamaId",
                table: "DataKaryawan",
                column: "AgamaId");

            migrationBuilder.CreateIndex(
                name: "IX_DataKaryawan_DepartemenId",
                table: "DataKaryawan",
                column: "DepartemenId");

            migrationBuilder.CreateIndex(
                name: "IX_DataKaryawan_JabatanId",
                table: "DataKaryawan",
                column: "JabatanId");

            migrationBuilder.CreateIndex(
                name: "IX_DataKaryawan_JenisKelaminId",
                table: "DataKaryawan",
                column: "JenisKelaminId");

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

            migrationBuilder.DropIndex(
                name: "IX_DataKaryawan_AgamaId",
                table: "DataKaryawan");

            migrationBuilder.DropIndex(
                name: "IX_DataKaryawan_DepartemenId",
                table: "DataKaryawan");

            migrationBuilder.DropIndex(
                name: "IX_DataKaryawan_JabatanId",
                table: "DataKaryawan");

            migrationBuilder.DropIndex(
                name: "IX_DataKaryawan_JenisKelaminId",
                table: "DataKaryawan");

            migrationBuilder.DropColumn(
                name: "AgamaId",
                table: "DataKaryawan");

            migrationBuilder.DropColumn(
                name: "DepartemenId",
                table: "DataKaryawan");

            migrationBuilder.DropColumn(
                name: "JabatanId",
                table: "DataKaryawan");

            migrationBuilder.DropColumn(
                name: "JenisKelaminId",
                table: "DataKaryawan");

            migrationBuilder.AddColumn<int>(
                name: "DataKaryawanId",
                table: "JenisKelamin",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataKaryawanId",
                table: "Jabatan",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataKaryawanId",
                table: "Departemen",
                type: "integer",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DataKaryawanId",
                table: "Agama",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_JenisKelamin_DataKaryawanId",
                table: "JenisKelamin",
                column: "DataKaryawanId");

            migrationBuilder.CreateIndex(
                name: "IX_Jabatan_DataKaryawanId",
                table: "Jabatan",
                column: "DataKaryawanId");

            migrationBuilder.CreateIndex(
                name: "IX_Departemen_DataKaryawanId",
                table: "Departemen",
                column: "DataKaryawanId");

            migrationBuilder.CreateIndex(
                name: "IX_Agama_DataKaryawanId",
                table: "Agama",
                column: "DataKaryawanId");

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
    }
}
