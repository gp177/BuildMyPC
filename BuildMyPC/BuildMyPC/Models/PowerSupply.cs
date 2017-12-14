using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildMyPC.Models
{
    public class PowerSupply
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        public string Efficiency { get; set; }
        public int Watts { get; set; }
        public bool IsModular { get; set; }
        public double Price { get; set; }


    }
}