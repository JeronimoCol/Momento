using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly3.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
       // [StringLength(225)]
        public string Name { get; set; }
        [Display(Name = "Suscribed to New Letter ?")]
        public bool IsSuscribedToNewsLetter { get; set; }
        [ForeignKey("MembershipTypeId")]
        
        public MembershipType MembershipType { get; set; }
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }
        [Display(Name = "Data Of Brith")]
        public DateTime? Birthdate { get; set; }
    }
}