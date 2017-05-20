using System;
using System.Collections.Generic;

namespace EfCore2Demo.Model
{
    public partial class Regions
    {
        public Regions()
        {
            Territories = new HashSet<Territories>();
        }

        public long RegionId { get; set; }
        public string RegionDescription { get; set; }

        public ICollection<Territories> Territories { get; set; }
    }
}
