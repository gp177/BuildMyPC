using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BuildMyPC.Models
{
    public class Motherboard
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        [Required]
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        [Required]
        public string Socket { get; set; }
        public string FormFactor { get; set; }
        [Range(1, 128)]
        public int MaxRAM { get; set; }
        [Range(1, 10000)]
        public double Price { get; set; }
       
        
    }
}