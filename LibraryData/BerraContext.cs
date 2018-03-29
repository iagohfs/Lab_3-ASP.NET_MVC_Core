using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LibraryData
{
    public class BerraContext : DbContext
    {
        public BerraContext(DbContextOptions options) : base(options) { }

        public DbSet<BookingTicket> BookingTickets { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Cinema> Cinema { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Room> Rooms { get; set; }
    }
}
