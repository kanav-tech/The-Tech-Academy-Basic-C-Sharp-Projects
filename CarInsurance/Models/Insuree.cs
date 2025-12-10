using System;
using System.ComponentModel.DataAnnotations;

namespace CarInsurance.Models
{
    public class Insuree
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Car Year")]
        [Range(1900, 2100)]
        public int CarYear { get; set; }

        [Required]
        [Display(Name = "Car Make")]
        public string CarMake { get; set; }

        [Required]
        [Display(Name = "Car Model")]
        public string CarModel { get; set; }

        [Display(Name = "DUI Offense?")]
        public bool DUI { get; set; }

        [Display(Name = "Number of Speeding Tickets")]
        [Range(0, 100)]
        public int SpeedingTickets { get; set; }

        [Display(Name = "Full Coverage?")]
        public bool CoverageType { get; set; }

        [Display(Name = "Monthly Quote")]
        [DataType(DataType.Currency)]
        public decimal Quote { get; set; }
    }
}