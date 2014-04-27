using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InRonStudenter.ModelLibrary;
using System.ComponentModel.DataAnnotations;

namespace InRonStudenter.ModelLibrary
{
    public class Address
    {   
        [Required(ErrorMessage="Please enter the home address")]
        [Display(Name="Address")]
        [DataType(DataType.MultilineText)]
        public String StreetAddress { get; set; }

        [Required(ErrorMessage="Please enter the Area")]
        [Display(Name = "Area")]
        public String Area { get; set; }

        [Required(ErrorMessage="Please enter City / Town / Village")]
        [Display(Name="City/Town/Village")]
        public String CityTownVillage { get; set; }

        [Required(ErrorMessage="Please enter state")]
        [Display(Name = "State")]
        public String State { get; set; }

        [Required(ErrorMessage = "Please enter country")]
        [Display(Name = "Country")]
        public String Country { get; set; }

        [Required(ErrorMessage = "Please enter a zip code")]
        [DataType(DataType.PostalCode)]
        [Display(Name = "PIN/ZIP Code")]
        public String AddressPINCode { get; set; }

        [Required, Display(Name="Contact Number")]
        [DataType(DataType.PhoneNumber)]
        public String ContactNumber { get; set; }

        [DataType(DataType.EmailAddress), Display(Name="Email Address"), Display(Name="Email")]
        public String Email { get; set; }
    }
}
