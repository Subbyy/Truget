using System.ComponentModel.DataAnnotations;

namespace TrugetApp.Models
{
    public class AddressModel
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public IdNameModel Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string ZipCode { get; set; }
    }
}