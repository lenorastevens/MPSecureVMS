using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MPSecureVMS.Models
{
    public class Vendor
    {
        [Key]
        public int VendorId { get; set; }

        [Display(Name = "Vendor Name"), Required]
        public string VendorName { get; set; } = "";

        [Required]
        public string Contact { get; set; } = "";


        [Required]
        public string Position { get; set; } = "";

        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Contact Phone"), Required]
        public string ContactPhone { get; set; } = "";

        [DataType(DataType.EmailAddress)]
        [Display(Name = "Contact Email"), Required]
        public string ContactEmail { get; set; } = "";

        [Display(Name = "Street Address"), Required]
        public string VendorAddress { get; set; } = "";

        [Required]
        public string City { get; set; } = "";

        [Required]
        public string State { get; set; } = "";

        [DataType(DataType.PostalCode), Required]
        public int ZipCode { get; set; }

        public string Notes { get; set; } = "";
    }
}
