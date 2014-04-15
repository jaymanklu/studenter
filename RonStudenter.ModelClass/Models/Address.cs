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
        [Display(Name="Address")]
        public String StreetAddress { get; set; }
        [Display(Name = "Area")]
        public String Area { get; set; }
        [Display(Name="City/Town/Village")]
        public String CityTownVillage { get; set; }
        [Display(Name = "State")]
        public String State { get; set; }
        [Display(Name = "Country")]
        public String Country { get; set; }
        [Display(Name = "PIN/ZIP Code")]
        public String AddressPINCode { get; set; }
        [Required, Display(Name="Contact Number")]
        public String ContactNumber { get; set; }
        [DataType(DataType.EmailAddress), Display(Name="Email Address")]
        public String Email { get; set; }
    }
}
