using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuariosApi.Migrations
{
    public partial class primeira : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "7b88fb51-85b6-4be5-abe4-72cb78869d95");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "9cc43db2-216e-42bd-95fb-83233b59c24e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "169b86a8-bbcd-490c-944d-8ddb54c44d6d", "AQAAAAEAACcQAAAAELLir3KZ3cXhJjXaQr3y8/tnnlqlNt528mqUUTdwZAlbpoSb2hf+7y9HFAQv0gheAQ==", "2b1b4bb4-c526-4659-863d-81d0ea1b92f5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
