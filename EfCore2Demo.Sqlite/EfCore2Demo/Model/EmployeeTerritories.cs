﻿using System;
using System.Collections.Generic;

namespace EfCore2Demo.Model
{
    public partial class EmployeeTerritories
    {
        public long EmployeeId { get; set; }
        public string TerritoryId { get; set; }

        public Employees Employee { get; set; }
        public Territories Territory { get; set; }
    }
}
