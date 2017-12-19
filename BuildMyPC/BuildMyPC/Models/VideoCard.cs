using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BuildMyPC.Models
{
    public class VideoCard
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        [Required]
        public int Memory { get; set; }
        public double CoreClock { get; set; }
        public double Price { get; set; }
    }
}