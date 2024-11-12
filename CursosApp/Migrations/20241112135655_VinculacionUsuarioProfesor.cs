using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CursosApp.Migrations
{
    /// <inheritdoc />
    public partial class VinculacionUsuarioProfesor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ProfesorID",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_ProfesorID",
                table: "AspNetUsers",
                column: "ProfesorID");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Profesores_ProfesorID",
                table: "AspNetUsers",
                column: "ProfesorID",
                principalTable: "Profesores",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Profesores_ProfesorID",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_ProfesorID",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "ProfesorID",
                table: "AspNetUsers");
        }
    }
}
