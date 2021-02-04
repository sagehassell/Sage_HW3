using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sage_HW3.Models
{
    public class EnterMovie
    {
        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }
        
        [Required]
        public int Year { get; set; }
        
        [Required]
        public string Director { get; set; }
        
        [Required]
        public int Rating { get; set; }

        public bool Edited { get; set; }
        public string Lent { get; set; }
        public string Notes { get; set; }
    }
}
