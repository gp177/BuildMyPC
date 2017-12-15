using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BuildMyPC.Models
{
    public class PowerSupply
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        [Required]
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        [Required]
        public string Efficiency { get; set; }
        public int Watts { get; set; }
        public bool IsModular { get; set; }
        public double Price { get; set; }


    }
}