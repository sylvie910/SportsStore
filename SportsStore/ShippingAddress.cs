using System.ComponentModel.DataAnnotations;

namespace SportsStore
{
    public class ShippingAddress
    {
        public int CustomerId { get; set; }
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the first address line")]
        [Display(Name = "Address Line 1")]
        public string AddressLine1 { get; set; }
        [Display(Name = "Address Line 2")]
        public string AddressLine2 { get; set; }
        [Display(Name = "Address Line 3")]
        public string AddressLine3 { get; set; }
        [Required(ErrorMessage = "Please enter a city name")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a state name")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter the zipcode")]
        public string ZipCode { get; set; }
        [Required(ErrorMessage = "Please enter a country name")]
        public string Country { get; set; }
        public bool GiftWrap { get; set; }
    }
}
