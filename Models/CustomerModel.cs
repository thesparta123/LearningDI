using LearningDI.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace LearningDI.Models
{
    class CustomerModel : ICustomer
    {
        [Required]
        public int CustomerID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage ="Please enter your name!")]
        [MinLength(4, ErrorMessage = "Minimum is 4 digit")]
        [MaxLength(50, ErrorMessage = "sorry this is higher limit you can enter")]
        [RegularExpression("^[a-zA-Z'-]+", ErrorMessage = "Please enter a valid Name")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your emailID!")]
        [MinLength(5, ErrorMessage = "Minimum is 5 digit")]
        [MaxLength(100, ErrorMessage = "sorry this is higher limit you can enter")]
        [RegularExpression("^[0-9a-z.-_]+@[a-z]+.[a-z]+$", ErrorMessage = "Please enter a valid Email")]
        public string EmailID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter your Phone Number!")]
        [RegularExpression("^[1-9]{1}[0-9]{2}-[0-9]{3}-[0-9]{4}$", ErrorMessage = "Please enter a valid phone number")]
        public string PhoneNumber { get; set; }
    }
}
