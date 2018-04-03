using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibraryData.Migrations
{
    public partial class Small_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Rooms_RoomId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_RoomId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Rooms");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Movies",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_RoomId",
                table: "Movies",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Rooms_RoomId",
                table: "Movies",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Rooms_RoomId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_RoomId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Movies");

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Rooms",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomId",
                table: "Rooms",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Rooms_RoomId",
                table: "Rooms",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
