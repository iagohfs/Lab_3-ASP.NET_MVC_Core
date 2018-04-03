using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibraryData.Migrations
{
    public partial class remodelling : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cinema_BookingTickets_BookingTicketId",
                table: "Cinema");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_BookingTickets_BookingTicketId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_BookingTickets_BookingTicketId",
                table: "Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_BookingTickets_BookingTicketId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_BookingTicketId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Movies_BookingTicketId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Clients_BookingTicketId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Cinema_BookingTicketId",
                table: "Cinema");

            migrationBuilder.DropColumn(
                name: "BookingTicketId",
                table: "Rooms");

            migrationBuilder.DropColumn(
                name: "BookingTicketId",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "BookingTicketId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "BookingTicketId",
                table: "Cinema");

            migrationBuilder.AddColumn<int>(
                name: "ClientId",
                table: "BookingTickets",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BookingTickets_ClientId",
                table: "BookingTickets",
                column: "ClientId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookingTickets_Clients_ClientId",
                table: "BookingTickets",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookingTickets_Clients_ClientId",
                table: "BookingTickets");

            migrationBuilder.DropIndex(
                name: "IX_BookingTickets_ClientId",
                table: "BookingTickets");

            migrationBuilder.DropColumn(
                name: "ClientId",
                table: "BookingTickets");

            migrationBuilder.AddColumn<int>(
                name: "BookingTicketId",
                table: "Rooms",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookingTicketId",
                table: "Movies",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookingTicketId",
                table: "Clients",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookingTicketId",
                table: "Cinema",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_BookingTicketId",
                table: "Rooms",
                column: "BookingTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_BookingTicketId",
                table: "Movies",
                column: "BookingTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_BookingTicketId",
                table: "Clients",
                column: "BookingTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Cinema_BookingTicketId",
                table: "Cinema",
                column: "BookingTicketId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cinema_BookingTickets_BookingTicketId",
                table: "Cinema",
                column: "BookingTicketId",
                principalTable: "BookingTickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_BookingTickets_BookingTicketId",
                table: "Clients",
                column: "BookingTicketId",
                principalTable: "BookingTickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_BookingTickets_BookingTicketId",
                table: "Movies",
                column: "BookingTicketId",
                principalTable: "BookingTickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_BookingTickets_BookingTicketId",
                table: "Rooms",
                column: "BookingTicketId",
                principalTable: "BookingTickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
