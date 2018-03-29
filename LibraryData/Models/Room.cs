using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryData.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }

        [Column("Status")]
        [MaxLength(32)]
        public string Status { get; set; }

        public int Seats { get; set; }

        public virtual Cinema CurrentCinema { get; set; }
        public virtual IEnumerable<Movie> Movies { get; set; }

    }
}
