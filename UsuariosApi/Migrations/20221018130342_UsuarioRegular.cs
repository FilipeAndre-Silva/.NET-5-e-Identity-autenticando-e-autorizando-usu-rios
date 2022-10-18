using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuariosApi.Migrations
{
    public partial class UsuarioRegular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "933d3ba5-62f0-407d-924b-6b781f2ad858");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99997, "79e247dd-fc22-4e89-b221-673f1f0ab017", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0d31e7a-7ed0-46a9-9b7d-c21c9d5e9b07", "AQAAAAEAACcQAAAAECmtbbx0dToFB5767bGMY0wH9CJTg8fWDgdMF5gvQKpOnvEiK+fDk8kGZG9REF1sKg==", "e63369c1-7a3d-40e3-ab17-7e8c63fcf8f3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "6c8d11f0-185f-4886-93ed-83d52744f0e4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6eb4366-aab8-4241-95f4-7ed51f285f71", "AQAAAAEAACcQAAAAEMdVgNvnDCVmNc4mq1CZeeKQjb1LS5wFGYL/QTqTUwByBy4nd5gzt+29z1CZRMOaQw==", "e6b4fdf6-28c3-4c04-8422-b0261a30a15f" });
        }
    }
}
