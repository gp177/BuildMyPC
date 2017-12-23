using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BuildMyPC.Models
{
    public class Build
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public CPU CPU { get; set; }
        public int CPUId { get; set; }

        public Memory Memory { get; set; }
        public int MemoryId { get; set; }


        public Motherboard Motherboard { get; set; }
        public int MotherboardId { get; set; }

        public Storage Storage { get; set; }
        public int StorageId { get; set; }

        public VideoCard VideoCard { get; set; }
        public int VideoCardId { get; set; }

        public Case Case { get; set; }
        public int CaseId { get; set; }

        public PowerSupply PowerSupply { get; set; }
        public int PowerSupplyId { get; set; }
    }
}