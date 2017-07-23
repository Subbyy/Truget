using System.Collections.Generic;

namespace TrugetApp.Models
{
    public class CompanyModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string PLCNumber { get; set; }
        public int TotalTrucks { get; set; }
        public List<IdNameModel> TrucksTypes { get; set; }
        public AddressModel Address { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string Logo { get; set; }
    }
}