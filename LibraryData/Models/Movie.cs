using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryData.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }

        [Column("Title")]
        [MaxLength(32)]
        public string Title { get; set; }

        [Column("Director")]
        [MaxLength(64)]
        public string Director { get; set; }

        [Column("Genre")]
        [MaxLength(32)]
        public string Genre { get; set; }

        public string ImageURL { get; set; }

        public int AgeRange { get; set; }
        public decimal Price { get; set; }


    }
}
