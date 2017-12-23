using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BuildMyPC.Models
{
    public class Case
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        [Required]
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        [Required]
        [MaxLength(10)]
        public string TowerType { get; set; }
        public bool ComesWithPowerSupply { get; set; }
        [Range(1, 1000)]
        public double Price { get; set; }

    }
}