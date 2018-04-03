﻿// <auto-generated />
using LibraryData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace LibraryData.Migrations
{
    [DbContext(typeof(BerraContext))]
    [Migration("20180403131729_Small_update")]
    partial class Small_update
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LibraryData.Models.BookingTicket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BookingDate");

                    b.Property<int?>("ClientId");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("BookingTickets");
                });

            modelBuilder.Entity("LibraryData.Models.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnName("Name")
                        .HasMaxLength(32);

                    b.Property<DateTime>("OpenTime");

                    b.HasKey("Id");

                    b.ToTable("Cinema");
                });

            modelBuilder.Entity("LibraryData.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CinemaId");

                    b.Property<string>("FirstName")
                        .HasColumnName("FirstName")
                        .HasMaxLength(32);

                    b.Property<int?>("MovieId");

                    b.Property<int?>("RoomId");

                    b.Property<int>("TelephoneNumber");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.HasIndex("MovieId");

                    b.HasIndex("RoomId");

                    b.ToTable("Clients");
                });

            modelBuilder.Entity("LibraryData.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AgeRange");

                    b.Property<string>("Director")
                        .HasColumnName("Director")
                        .HasMaxLength(64);

                    b.Property<string>("Genre")
                        .HasColumnName("Genre")
                        .HasMaxLength(32);

                    b.Property<string>("ImageURL");

                    b.Property<decimal>("Price");

                    b.Property<int?>("RoomId");

                    b.Property<string>("Title")
                        .HasColumnName("Title")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.HasIndex("RoomId");

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("LibraryData.Models.Room", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Seats");

                    b.Property<string>("Status")
                        .HasColumnName("Status")
                        .HasMaxLength(32);

                    b.HasKey("Id");

                    b.ToTable("Rooms");
                });

            modelBuilder.Entity("LibraryData.Models.BookingTicket", b =>
                {
                    b.HasOne("LibraryData.Models.Client")
                        .WithMany("BookingTicket")
                        .HasForeignKey("ClientId");
                });

            modelBuilder.Entity("LibraryData.Models.Client", b =>
                {
                    b.HasOne("LibraryData.Models.Cinema", "Cinema")
                        .WithMany("Client")
                        .HasForeignKey("CinemaId");

                    b.HasOne("LibraryData.Models.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId");

                    b.HasOne("LibraryData.Models.Room", "Room")
                        .WithMany()
                        .HasForeignKey("RoomId");
                });

            modelBuilder.Entity("LibraryData.Models.Movie", b =>
                {
                    b.HasOne("LibraryData.Models.Room")
                        .WithMany("Movies")
                        .HasForeignKey("RoomId");
                });
#pragma warning restore 612, 618
        }
    }
}
