using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InsuranceCompanyMVC.Models
{
    public enum ClaimType { Car, House, Theft }
    public class Claim
    {
        public int ClaimId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfIncident { get; set; }

        public DateTime DateOfClaim { get; set; }

        public double InsuranceAmount { get; set; }

        public ClaimType ClaimType { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string StreetName { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public int PhoneNumber { get; set; }
        public string FullName => $"{FirstName} {LastName}";


        
    }
}