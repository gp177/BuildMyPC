using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildMyPC.Models
{
    public class VideoCard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Brand Brand { get; set; }
        public int BrandId { get; set; }
        public int Memory { get; set; }
        public double CoreClock { get; set; }
        public double Price { get; set; }
    }
}