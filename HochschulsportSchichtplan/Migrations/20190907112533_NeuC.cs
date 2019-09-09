using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HochschulsportSchichtplan.Migrations
{
    public partial class NeuC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ende",
                table: "Schicht");

            migrationBuilder.DropColumn(
                name: "Stunden",
                table: "Schicht");

            migrationBuilder.DropColumn(
                name: "Tag",
                table: "Schicht");

            migrationBuilder.RenameColumn(
                name: "Inhaber",
                table: "Schicht",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Schicht",
                newName: "EventId");

            migrationBuilder.AlterColumn<string>(
                name: "Start",
                table: "Schicht",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AddColumn<bool>(
                name: "AllDay",
                table: "Schicht",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Schicht",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "End",
                table: "Schicht",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AllDay",
                table: "Schicht");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Schicht");

            migrationBuilder.DropColumn(
                name: "End",
                table: "Schicht");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Schicht",
                newName: "Inhaber");

            migrationBuilder.RenameColumn(
                name: "EventId",
                table: "Schicht",
                newName: "Id");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Start",
                table: "Schicht",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Ende",
                table: "Schicht",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<double>(
                name: "Stunden",
                table: "Schicht",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<DateTime>(
                name: "Tag",
                table: "Schicht",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
