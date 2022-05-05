using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SSD_Assignment.Models
{
    public class ApplicationRole : IdentityRole
    {
        [Required]
        [RegularExpression(@"^[-a-zA-Z0-9 ]+$", ErrorMessage = "Only Alphabelts And Basic Punctuation Are Allowed")]
        public override string Name { get; set; }
        [Required]
        [RegularExpression(@"^[-a-zA-Z_.?!,:; ]+$", ErrorMessage = "Only Alphabelts And Basic Punctuation Are Allowed")]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string IPAddress { get; set; }

    }
}
