using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIRentalMobil.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class HapusLuarKota : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LuarKota",
                table: "TblPesanan");

            migrationBuilder.DropColumn(
                name: "LuarKota",
                table: "TblMobil");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "LuarKota",
                table: "TblPesanan",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "LuarKota",
                table: "TblMobil",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 1,
                column: "LuarKota",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 2,
                column: "LuarKota",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 3,
                column: "LuarKota",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 4,
                column: "LuarKota",
                value: false);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 5,
                column: "LuarKota",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 6,
                column: "LuarKota",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 7,
                column: "LuarKota",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 8,
                column: "LuarKota",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 9,
                column: "LuarKota",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 10,
                column: "LuarKota",
                value: false);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 11,
                column: "LuarKota",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 12,
                column: "LuarKota",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 13,
                column: "LuarKota",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 14,
                column: "LuarKota",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 15,
                column: "LuarKota",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblPesanan",
                keyColumn: "Id",
                keyValue: 1,
                column: "LuarKota",
                value: false);

            migrationBuilder.UpdateData(
                table: "TblPesanan",
                keyColumn: "Id",
                keyValue: 2,
                column: "LuarKota",
                value: false);

            migrationBuilder.UpdateData(
                table: "TblPesanan",
                keyColumn: "Id",
                keyValue: 3,
                column: "LuarKota",
                value: false);
        }
    }
}
