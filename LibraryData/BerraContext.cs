using LibraryData.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LibraryData
{
    public class BerraContext : DbContext
    {
        public BerraContext(DbContextOptions options) : base(options) { }

        public DbSet<Client> Clients { get; set; }
    }
}
