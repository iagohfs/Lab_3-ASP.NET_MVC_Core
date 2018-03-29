using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace LibraryData.Migrations
{
    public partial class FirstModels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Clients",
                maxLength: 32,
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BookingTicketId",
                table: "Clients",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CinemaId",
                table: "Clients",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoomId",
                table: "Clients",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BookingTickets",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookingDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingTickets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cinema",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookingTicketId = table.Column<int>(nullable: true),
                    Name = table.Column<string>(maxLength: 32, nullable: false),
                    OpenTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cinema", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cinema_BookingTickets_BookingTicketId",
                        column: x => x.BookingTicketId,
                        principalTable: "BookingTickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BookingTicketId = table.Column<int>(nullable: true),
                    CurrentCinemaId = table.Column<int>(nullable: true),
                    Seats = table.Column<int>(nullable: false),
                    Status = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Rooms_BookingTickets_BookingTicketId",
                        column: x => x.BookingTicketId,
                        principalTable: "BookingTickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Rooms_Cinema_CurrentCinemaId",
                        column: x => x.CurrentCinemaId,
                        principalTable: "Cinema",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AgeRange = table.Column<int>(nullable: false),
                    BookingTicketId = table.Column<int>(nullable: true),
                    CinemaId = table.Column<int>(nullable: true),
                    Director = table.Column<string>(maxLength: 64, nullable: true),
                    Genre = table.Column<string>(maxLength: 32, nullable: true),
                    ImageURL = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    RoomId = table.Column<int>(nullable: true),
                    Title = table.Column<string>(maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movies_BookingTickets_BookingTicketId",
                        column: x => x.BookingTicketId,
                        principalTable: "BookingTickets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movies_Cinema_CinemaId",
                        column: x => x.CinemaId,
                        principalTable: "Cinema",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Movies_Rooms_RoomId",
                        column: x => x.RoomId,
                        principalTable: "Rooms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_BookingTicketId",
                table: "Clients",
                column: "BookingTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_CinemaId",
                table: "Clients",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_RoomId",
                table: "Clients",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Cinema_BookingTicketId",
                table: "Cinema",
                column: "BookingTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_BookingTicketId",
                table: "Movies",
                column: "BookingTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_CinemaId",
                table: "Movies",
                column: "CinemaId");

            migrationBuilder.CreateIndex(
                name: "IX_Movies_RoomId",
                table: "Movies",
                column: "RoomId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_BookingTicketId",
                table: "Rooms",
                column: "BookingTicketId");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_CurrentCinemaId",
                table: "Rooms",
                column: "CurrentCinemaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_BookingTickets_BookingTicketId",
                table: "Clients",
                column: "BookingTicketId",
                principalTable: "BookingTickets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Cinema_CinemaId",
                table: "Clients",
                column: "CinemaId",
                principalTable: "Cinema",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Clients_Rooms_RoomId",
                table: "Clients",
                column: "RoomId",
                principalTable: "Rooms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clients_BookingTickets_BookingTicketId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Cinema_CinemaId",
                table: "Clients");

            migrationBuilder.DropForeignKey(
                name: "FK_Clients_Rooms_RoomId",
                table: "Clients");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Rooms");

            migrationBuilder.DropTable(
                name: "Cinema");

            migrationBuilder.DropTable(
                name: "BookingTickets");

            migrationBuilder.DropIndex(
                name: "IX_Clients_BookingTicketId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_CinemaId",
                table: "Clients");

            migrationBuilder.DropIndex(
                name: "IX_Clients_RoomId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "BookingTicketId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "CinemaId",
                table: "Clients");

            migrationBuilder.DropColumn(
                name: "RoomId",
                table: "Clients");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Clients",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 32,
                oldNullable: true);
        }
    }
}
