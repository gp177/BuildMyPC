using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BuildMyPC.Models;

namespace BuildMyPC.ViewModels
{
    public class IndexListViewModel
    {
        public Case Case { get; set; }

        public CPU Cpu { get; set; }

        public Memory Memory { get; set; }

        public Motherboard Motherboard { get; set; }

        public PowerSupply Powersupply { get; set; }

        public Storage Storage { get; set; }

        public VideoCard Videocard { get; set; }
    }
}