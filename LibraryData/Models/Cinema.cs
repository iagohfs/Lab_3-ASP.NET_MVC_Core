using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LibraryData.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column("Name")]
        [MaxLength(32)]
        public string Name { get; set; }

        public DateTime OpenTime { get; set; }

        public virtual IEnumerable<Client> Clients { get; set; }
        public virtual IEnumerable<Movie> Movies { get; set; }
    }
}
