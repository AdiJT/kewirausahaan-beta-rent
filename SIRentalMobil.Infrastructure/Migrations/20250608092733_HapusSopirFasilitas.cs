using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIRentalMobil.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class HapusSopirFasilitas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sopir",
                table: "TblPesanan");

            migrationBuilder.DropColumn(
                name: "Sopir",
                table: "TblMobil");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Sopir",
                table: "TblPesanan",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Sopir",
                table: "TblMobil",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 1,
                column: "Sopir",
                value: false);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 2,
                column: "Sopir",
                value: false);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 3,
                column: "Sopir",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 4,
                column: "Sopir",
                value: false);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 5,
                column: "Sopir",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 6,
                column: "Sopir",
                value: false);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 7,
                column: "Sopir",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 8,
                column: "Sopir",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 9,
                column: "Sopir",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 10,
                column: "Sopir",
                value: false);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 11,
                column: "Sopir",
                value: false);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 12,
                column: "Sopir",
                value: false);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 13,
                column: "Sopir",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 14,
                column: "Sopir",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblMobil",
                keyColumn: "Id",
                keyValue: 15,
                column: "Sopir",
                value: false);

            migrationBuilder.UpdateData(
                table: "TblPesanan",
                keyColumn: "Id",
                keyValue: 1,
                column: "Sopir",
                value: true);

            migrationBuilder.UpdateData(
                table: "TblPesanan",
                keyColumn: "Id",
                keyValue: 2,
                column: "Sopir",
                value: false);

            migrationBuilder.UpdateData(
                table: "TblPesanan",
                keyColumn: "Id",
                keyValue: 3,
                column: "Sopir",
                value: false);
        }
    }
}
