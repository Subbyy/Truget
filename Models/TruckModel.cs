using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TrugetApp._Resources;
using static Truget.Common.Enums;

namespace TrugetApp.Models
{
    public class TruckModel
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [Range(0.1, 20.0, ErrorMessageResourceType = typeof(Validations), ErrorMessageResourceName = "TruckMaxWidth")]
        public float MaxHeight { get; set; }
        [Required]
        public float MaxWidth { get; set; }
        [Required]
        public float MaxLength { get; set; }
        [Required]
        public float MaxWeight { get; set; }
        [Required]
        public TruckType Type { get; set; }
        [Required]
        public TruckSize Size { get; set; }
        [Required]
        public string UDID { get; set; }
        [Required]
        public CompanyModel Company { get; set; }
        public string Image { get; set; }
    }
}
