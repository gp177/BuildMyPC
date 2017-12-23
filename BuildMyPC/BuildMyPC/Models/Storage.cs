using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BuildMyPC.Models
{
    public class Storage
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        [Required]
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        public double Form { get; set; }
        [Required]
        public int Size { get; set; }
        public double Price { get; set; }

    }
}