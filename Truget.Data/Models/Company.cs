using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using static Truget.Common.Enums;

namespace Truget.Data.Models
{
    public class Company
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public string Name { get; set; }
        public string PLCNumber { get; set; }
        public int TotalTrucks { get; set; }
        public string TrucksTypes { get; set; }
        public string TrucksSizes { get; set; }
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }
    }
}
