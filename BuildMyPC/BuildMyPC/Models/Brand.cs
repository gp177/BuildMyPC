using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BuildMyPC.Models
{
    public class Brand
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string BrandName { get; set; }
        [Required]
        [MaxLength(60)]
        public string Country { get; set; }
    }
}