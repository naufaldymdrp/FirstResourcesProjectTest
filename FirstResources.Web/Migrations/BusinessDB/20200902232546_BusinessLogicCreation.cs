using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FirstResources.Web.Migrations.BusinessDB
{
    public partial class BusinessLogicCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataKaryawan",
                columns: table => new
                {
                    DataKaryawanId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NIK = table.Column<string>(nullable: true),
                    Nama = table.Column<string>(nullable: true),
                    Alamat = table.Column<string>(nullable: true),
                    TanggalLahir = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataKaryawan", x => x.DataKaryawanId);
                });

            migrationBuilder.CreateTable(
                name: "Agama",
                columns: table => new
                {
                    AgamaId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaAgama = table.Column<string>(nullable: true),
                    DataKaryawanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agama", x => x.AgamaId);
                    table.ForeignKey(
                        name: "FK_Agama_DataKaryawan_DataKaryawanId",
                        column: x => x.DataKaryawanId,
                        principalTable: "DataKaryawan",
                        principalColumn: "DataKaryawanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departemen",
                columns: table => new
                {
                    DepartemenId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nama = table.Column<string>(nullable: true),
                    DataKaryawanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departemen", x => x.DepartemenId);
                    table.ForeignKey(
                        name: "FK_Departemen_DataKaryawan_DataKaryawanId",
                        column: x => x.DataKaryawanId,
                        principalTable: "DataKaryawan",
                        principalColumn: "DataKaryawanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Jabatan",
                columns: table => new
                {
                    JabatanId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nama = table.Column<string>(nullable: true),
                    DataKaryawanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jabatan", x => x.JabatanId);
                    table.ForeignKey(
                        name: "FK_Jabatan_DataKaryawan_DataKaryawanId",
                        column: x => x.DataKaryawanId,
                        principalTable: "DataKaryawan",
                        principalColumn: "DataKaryawanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JenisKelamin",
                columns: table => new
                {
                    JenisKelaminId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NamaJenisKelamin = table.Column<string>(nullable: true),
                    DataKaryawanId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JenisKelamin", x => x.JenisKelaminId);
                    table.ForeignKey(
                        name: "FK_JenisKelamin_DataKaryawan_DataKaryawanId",
                        column: x => x.DataKaryawanId,
                        principalTable: "DataKaryawan",
                        principalColumn: "DataKaryawanId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agama_DataKaryawanId",
                table: "Agama",
                column: "DataKaryawanId");

            migrationBuilder.CreateIndex(
                name: "IX_Departemen_DataKaryawanId",
                table: "Departemen",
                column: "DataKaryawanId");

            migrationBuilder.CreateIndex(
                name: "IX_Jabatan_DataKaryawanId",
                table: "Jabatan",
                column: "DataKaryawanId");

            migrationBuilder.CreateIndex(
                name: "IX_JenisKelamin_DataKaryawanId",
                table: "JenisKelamin",
                column: "DataKaryawanId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agama");

            migrationBuilder.DropTable(
                name: "Departemen");

            migrationBuilder.DropTable(
                name: "Jabatan");

            migrationBuilder.DropTable(
                name: "JenisKelamin");

            migrationBuilder.DropTable(
                name: "DataKaryawan");
        }
    }
}
