using System;
using System.Collections.Generic;

namespace EfCore2Demo.Model
{
    public partial class Territories
    {
        public Territories()
        {
            EmployeeTerritories = new HashSet<EmployeeTerritories>();
        }

        public string TerritoryId { get; set; }
        public string TerritoryDescription { get; set; }
        public long RegionId { get; set; }

        public ICollection<EmployeeTerritories> EmployeeTerritories { get; set; }
        public Regions Region { get; set; }
    }
}
