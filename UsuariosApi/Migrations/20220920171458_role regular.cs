using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuariosApi.Migrations
{
    public partial class roleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "ede51d6f-9265-4da7-8ddb-e8744f1db044");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "28e3c866-cdbb-48d0-816c-2b8b74f005b5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77da29c2-74ad-40e5-aaab-ea2f79c927e0", "AQAAAAEAACcQAAAAENsbobmpuPlhPi/T5T+QBpNnMrqzGvgqwbBgiCdFz+Ce+hpxAl+4aLwgLpBCU77IaQ==", "6aae648b-7b28-4c8f-815d-e1a0da83db95" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
