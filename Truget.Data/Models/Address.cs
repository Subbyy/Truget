using System;
using System.Collections.Generic;
using System.Text;

namespace Truget.Data.Models
{
    public class Address
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string ZipCode { get; set; }
    }
}
