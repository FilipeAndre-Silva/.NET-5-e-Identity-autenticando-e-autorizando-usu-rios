using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UsuariosApi.Migrations
{
    public partial class UsuarioCustom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "b671e29f-c07c-4485-bfad-093c6302fbe3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "44cfd638-550d-473e-8059-525c81096fd2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4413244b-7c31-445a-b8f2-929701a2598f", "AQAAAAEAACcQAAAAEE6b3nC8Kqk2MB+aNk9Q/LDRtBG/GFIcRczTVvlMMF/Y2rfNDPhUdjxrPMYGfgCrwQ==", "792a843d-cece-49c9-a8e9-6f4d88d62a4b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "79e247dd-fc22-4e89-b221-673f1f0ab017");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "933d3ba5-62f0-407d-924b-6b781f2ad858");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0d31e7a-7ed0-46a9-9b7d-c21c9d5e9b07", "AQAAAAEAACcQAAAAECmtbbx0dToFB5767bGMY0wH9CJTg8fWDgdMF5gvQKpOnvEiK+fDk8kGZG9REF1sKg==", "e63369c1-7a3d-40e3-ab17-7e8c63fcf8f3" });
        }
    }
}
