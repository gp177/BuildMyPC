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
        public IEnumerable<CPU> Cpus { get; set; }
        public IEnumerable<Memory> memorys { get; set; }
        public IEnumerable<Case> cases { get; set; }
        public IEnumerable<Storage> storeges { get; set; }
        public IEnumerable<PowerSupply> PowerSupplyes  { get; set; }
        public IEnumerable<Motherboard> motherboards { get; set; }
        public IEnumerable<VideoCard> videoCards { get; set; }

    }
}