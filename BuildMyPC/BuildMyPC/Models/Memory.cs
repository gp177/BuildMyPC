using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildMyPC.Models
{
    public class Memory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        public string Speed { get; set; }
        public string PinType { get; set; }
        public int Size { get; set; }
        public int Latency { get; set; }
        public double Price { get; set; }
    }
}