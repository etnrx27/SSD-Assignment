using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SSD_Assignment.Models
{
    public class Feedback
    {
        public int ID { get; set; }
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Only Alphabelts Are Allowed")]
        [Required]
        public string Name { get; set; }
        [RegularExpression(@"^[-a-zA-Z_.?! ]+$", ErrorMessage = "Only Alphabelts And Some Basic Punctuation Are Allowed")]
        [Required]
        public string Subject { get; set; }
        [RegularExpression(@"^[-a-zA-Z_.?!,:; ]+$", ErrorMessage = "Only Alphabelts And Basic Punctuation Are Allowed")]
        [Required]
        public string Text { get; set; }
        public DateTime Date { get; set; }
    }
}
