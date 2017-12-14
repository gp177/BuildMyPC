using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildMyPC.Models
{
    public class Motherboard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        public string Socket { get; set; }
        public string FormFactor { get; set; }
        public int MaxRAM { get; set; }
        public double Price { get; set; }
       
        
    }
}