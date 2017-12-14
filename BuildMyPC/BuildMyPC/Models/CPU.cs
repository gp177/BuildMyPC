using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildMyPC.Models
{
    public class CPU
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        public double Speed { get; set; }
        public byte Cores { get; set; }
        public int PowerConsumption { get; set; }
        public double Price { get; set; }
    }
}