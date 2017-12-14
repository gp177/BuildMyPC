using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildMyPC.Models
{
    public class Case
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        public string TowerType { get; set; }
        public bool ComesWithPowerSupply { get; set; }
        public double Price { get; set; }

    }
}