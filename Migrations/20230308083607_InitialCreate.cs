using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QuanLyCongTy.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PhongBan",
                columns: table => new
                {
                    MaPB = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenPB = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhongBan", x => x.MaPB);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNV = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViTri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QueQuan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DanToc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaPB1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNV);
                    table.ForeignKey(
                        name: "FK_NhanVien_PhongBan_MaPB1",
                        column: x => x.MaPB1,
                        principalTable: "PhongBan",
                        principalColumn: "MaPB");
                });

            migrationBuilder.CreateTable(
                name: "Luong",
                columns: table => new
                {
                    MaNV1 = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhongBan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViTri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayCong = table.Column<int>(type: "int", nullable: false),
                    LuongViTri = table.Column<int>(type: "int", nullable: false),
                    SoCongChuan = table.Column<int>(type: "int", nullable: false),
                    LuongNgayCong = table.Column<int>(type: "int", nullable: false),
                    LuongPhuCap = table.Column<int>(type: "int", nullable: false),
                    Thuong = table.Column<int>(type: "int", nullable: false),
                    KhauTru = table.Column<int>(type: "int", nullable: false),
                    TamUng = table.Column<int>(type: "int", nullable: false),
                    ThucNhan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_Luong_NhanVien_MaNV1",
                        column: x => x.MaNV1,
                        principalTable: "NhanVien",
                        principalColumn: "MaNV",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Luong_MaNV1",
                table: "Luong",
                column: "MaNV1");

            migrationBuilder.CreateIndex(
                name: "IX_NhanVien_MaPB1",
                table: "NhanVien",
                column: "MaPB1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Luong");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "PhongBan");
        }
    }
}
