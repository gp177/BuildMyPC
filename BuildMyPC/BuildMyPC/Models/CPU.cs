using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BuildMyPC.Models
{
    public class CPU
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        [Required]
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        [Range(1 ,10)]
        public double Speed { get; set; }
        [Range(1 ,32)]
        public byte Cores { get; set; }
        [Range(1, 1000)]
        public int PowerConsumption { get; set; }
        [Range(1, 10000)]
        public double Price { get; set; }
    }
}