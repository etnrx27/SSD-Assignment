using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SSD_Assignment.Models
{
    public class Payment
    {
        public int ID { get; set; }
        [Required]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Only Alphabelts Are Allowed")]
        public string Name { get; set; }
        [Required]
        [RegularExpression(@"^[-a-zA-Z0-9_@!#. ]+$", ErrorMessage = "Only Alphabelts Are Allowed")]
        public string Email { get; set; }
        [Required]
        [RegularExpression(@"^[-0-9]{19}$", ErrorMessage = "Only 16 Numbers And 4 '-' Are Allowed")]
        public string CardNo { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime CardExpiryDate { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]{3}$", ErrorMessage = "Only 3 Numbers Are Allowed")]
        public string CardCSV { get; set; }
        [Required]
        [RegularExpression(@"^[-a-zA-Z0-9# ]+$", ErrorMessage = "Only Alphanumericals And '#','-' Are Allowed")]
        public string Address { get; set; }
        [Required]
        [RegularExpression(@"^[0-9]{6}$", ErrorMessage = "Only 6 Numbers Are Allowed")]
        public string PostalCode { get; set; }
        [Required]
        [RegularExpression(@"^[89]\d{7}$", ErrorMessage = "Only 8 Numbers Are Allowed And First Number Is Either '8' Or '9'")]
        public string PhoneNumber { get; set; }
    }
}
