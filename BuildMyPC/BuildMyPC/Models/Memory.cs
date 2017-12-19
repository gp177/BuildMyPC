using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BuildMyPC.Models
{
    public class Memory
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        [Required]
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        [Required]
        [MaxLength(30)]
        public string Speed { get; set; }
        [Required]
        public string PinType { get; set; }
        [Range(1,40)]
        public int Size { get; set; }
        [Range(1, 50)]
        public double Latency { get; set; }
        [Range(1, 1000)]
        public double Price { get; set; }
    }
}