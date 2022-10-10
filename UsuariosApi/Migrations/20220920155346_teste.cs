using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuariosApi.Migrations
{
    public partial class teste : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "666e2fca-2081-47c3-bb1a-36fb9eb0277a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "f287e529-3f84-4248-ac45-e33def73db98");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cd91953-6ef3-47ea-9c6b-1a97294e26a4", "AQAAAAEAACcQAAAAEKOBO+dnwaDqTdM9NRt7cPR3N82zHAxlIPTwcyOplQjHcOVA0SFp9XsqYNZ3D7/mow==", "22b36ba7-991d-46c2-a4b2-b30cf1bd76d9" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "3f66d0fa-2aa8-4c89-8db0-7d739b4cb51e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "a2624c45-c958-4025-93ad-d09c9094c101");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e920950-d858-493f-bd7f-85da4aa0bf37", "AQAAAAEAACcQAAAAEHVZ8qyxKvENdbqGUH7kEdNQ2reFYTJWvYDfODsm7+4SSL3RZxiEONJ199EDs9mlWg==", "6d316862-9a50-43f7-9190-a4948e9c4102" });
        }
    }
}
