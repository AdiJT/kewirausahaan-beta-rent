using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SIRentalMobil.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EditPesanan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblPesanan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TanggalAkhirSewa", "TanggalAwalSewa", "TanggalPesan" },
                values: new object[] { new DateTime(2024, 6, 2, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 29, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TblPesanan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TanggalAkhirSewa", "TanggalAwalSewa", "TanggalPesan" },
                values: new object[] { new DateTime(2024, 5, 28, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 26, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 25, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TblPesanan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TanggalAkhirSewa", "TanggalAwalSewa", "TanggalPesan" },
                values: new object[] { new DateTime(2024, 5, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 27, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 24, 12, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TblPesanan",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "TanggalAkhirSewa", "TanggalAwalSewa", "TanggalPesan" },
                values: new object[] { new DateTime(2024, 12, 4, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TblPesanan",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "TanggalAkhirSewa", "TanggalAwalSewa", "TanggalPesan" },
                values: new object[] { new DateTime(2024, 12, 3, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 12, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "TblPesanan",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "TanggalAkhirSewa", "TanggalAwalSewa", "TanggalPesan" },
                values: new object[] { new DateTime(2024, 11, 30, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 12, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
