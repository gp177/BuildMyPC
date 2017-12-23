using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BuildMyPC.Models;

namespace BuildMyPC.ViewModels
{
    public class BuildViewModel
    {

        public Build builds { get; set; }

        public Case Case { get; set; }
        public Brand CaseBrand { get; set; }

        public CPU Cpu { get; set; }
        public Brand CpuBrand { get; set; }

        public Memory Memory { get; set; }
        public Brand  MemoryBrand { get; set; }

        public Motherboard Motherboard { get; set; }
        public Brand MotherboardBrand { get; set; }

        public PowerSupply Powersupply { get; set; }
        public Brand PowersupplyBrand { get; set; }

        public Storage Storage { get; set; }
        public Brand StorageBrand { get; set; }

        public VideoCard Videocard { get; set; }
        public Brand VideocardBrand { get; set; }



    }
}