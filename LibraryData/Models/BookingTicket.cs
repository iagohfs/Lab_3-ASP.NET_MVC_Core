using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace LibraryData.Models
{
    public class BookingTicket
    {
        [Key]
        public int Id { get; set; }

        public DateTime BookingDate { get; set; }

        public virtual IEnumerable<Movie> Movie { get; set; }
        public virtual IEnumerable<Room> Room { get; set; }
        public virtual IEnumerable<Cinema> Cinema { get; set; }
        public virtual IEnumerable<Client> Client { get; set; }

    }
}
