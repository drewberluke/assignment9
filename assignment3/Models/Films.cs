using System;
using System.ComponentModel.DataAnnotations;

namespace assignment3.Models
{
    public class Films
    {
        [Key]
        public int id { get; set; }

        [Required]
        public string category { get; set; }

        [Required]
        public string title { get; set; }

        [Required]
        public int year { get; set; }

        [Required]
        public string director { get; set; }

        [Required]
        public string rating { get; set; }

        public bool edited { get; set; }

        public string lent { get; set; }

        public string notes { get; set; }
    }
}
