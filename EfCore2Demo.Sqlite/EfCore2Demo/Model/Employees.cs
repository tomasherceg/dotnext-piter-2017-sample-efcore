﻿using System;
using System.Collections.Generic;

namespace EfCore2Demo.Model
{
    public partial class Employees
    {
        public Employees()
        {
            EmployeeTerritories = new HashSet<EmployeeTerritories>();
            Orders = new HashSet<Orders>();
        }

        public long EmployeeId { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public string BirthDate { get; set; }
        public string HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        public byte[] Photo { get; set; }
        public string Notes { get; set; }
        public long? ReportsTo { get; set; }
        public string PhotoPath { get; set; }

        public ICollection<EmployeeTerritories> EmployeeTerritories { get; set; }
        public ICollection<Orders> Orders { get; set; }
        public Employees Employee { get; set; }
        public Employees InverseEmployee { get; set; }
    }
}
