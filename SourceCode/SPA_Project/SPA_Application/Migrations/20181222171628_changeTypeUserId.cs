﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace SPA_Application.Migrations
{
    public partial class changeTypeUserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AspNetUsers_UserId1",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_UserId1",
                table: "Appointments");

            migrationBuilder.DropColumn(
                name: "UserId1",
                table: "Appointments");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Appointments",
                nullable: true,
                oldClrType: typeof(long));

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_UserId",
                table: "Appointments",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AspNetUsers_UserId",
                table: "Appointments",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Appointments_AspNetUsers_UserId",
                table: "Appointments");

            migrationBuilder.DropIndex(
                name: "IX_Appointments_UserId",
                table: "Appointments");

            migrationBuilder.AlterColumn<long>(
                name: "UserId",
                table: "Appointments",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId1",
                table: "Appointments",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_UserId1",
                table: "Appointments",
                column: "UserId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Appointments_AspNetUsers_UserId1",
                table: "Appointments",
                column: "UserId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
