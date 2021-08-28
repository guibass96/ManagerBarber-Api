using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ManangerBarberApi.Migrations
{
    public partial class AddTableClientes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CPF",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "Cliente",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telefone",
                table: "Cliente",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CPF",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Cliente");

            migrationBuilder.DropColumn(
                name: "Telefone",
                table: "Cliente");
        }
    }
}
