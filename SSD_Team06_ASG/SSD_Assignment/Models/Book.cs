using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SSD_Assignment.Models
{
    public class Book
    {
    public int ID { get; set; }
        [Required]
        [RegularExpression(@"^[-a-zA-Z0-9_?':, ]+$", ErrorMessage = "Only AlphaNumericals Are Allowed")]
        public string Title { get; set; }
        [Required]
        [RegularExpression(@"^[-a-zA-Z ]+$", ErrorMessage = "Only Alphabelts Are Allowed")]
        public string Author { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
        [RegularExpression(@"^[\w./_ ]+$", ErrorMessage = "Image Link used is not in acceptable format, imagefolder/image.jpg etc")]
        public string Image { get; set; } //Gets the Image Path; Then use this image path to input image into index
        [Required]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Only Alphabelts Are Allowed")]
        public string Genre { get; set; }
        [Required]
        public string Synopsis { get; set; }
    }
}