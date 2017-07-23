using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Truget.Data.Models
{
    public class Truck
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
        public float MaxHeight { get; set; }
        [Required]
        public float MaxWidth { get; set; }
        [Required]
        public float MaxLength { get; set; }
        [Required]
        public float MaxWeight { get; set; }
        public string Types { get; set; }
        public string Sizes { get; set; }
        [Required]
        public string UDID { get; set; }
        public Company Company { get; set; }
        public string Image { get; set; }
    }
}