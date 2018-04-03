using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibraryData.Migrations
{
    public partial class Remodel_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Cinema_CinemaId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Rooms_RoomId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Cinema_CurrentCinemaId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Movies_RoomId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "CinemaId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "CurrentCinemaId",
                table: "Rooms",
                newName: "RoomId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_CurrentCinemaId",
                table: "Rooms",
                newName: "IX_Rooms_RoomId");

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Clients",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clients_MovieId",
                table: "Clients",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Movies_MovieId",
                table: "Clients",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Rooms_RoomId",
                table: "Rooms",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Movies_MovieId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_Rooms_RoomId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Clients_MovieId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "MovieId",
                table: "Clients");

            migrationBuilder.RenameColumn(
                name: "RoomId",
                table: "Rooms",
                newName: "CurrentCinemaId");

            migrationBuilder.RenameIndex(
                name: "IX_Rooms_RoomId",
                table: "Rooms",
                newName: "IX_Rooms_CurrentCinemaId");

            migrationBuilder.AddColumn<int>(
                name: "CinemaId",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Movies",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_RoomId",
                table: "Movies",
                column: "RoomId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Cinema_CinemaId",
                table: "Movies",
                column: "CinemaId",
                principalTable: "Cinema",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Rooms_RoomId",
                table: "Movies",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_Cinema_CurrentCinemaId",
                table: "Rooms",
                column: "CurrentCinemaId",
                principalTable: "Cinema",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
