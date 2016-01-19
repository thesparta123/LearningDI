using LearningDI.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace LearningDI.Models
{
    class ProductModel: IProducts
    {
        public int ItemID { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the product Name!")]
        [MinLength(4, ErrorMessage = "Minimum is 4 digit")]
        [MaxLength(50, ErrorMessage = "sorry this is higher limit you can enter")]
        [RegularExpression("^[a-zA-Z'-]+", ErrorMessage = "Please enter a valid Name")]
        public string ProductName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the product description!")]
        [MinLength(4, ErrorMessage = "Minimum is 4 digit")]
        [MaxLength(1000, ErrorMessage = "sorry this is higher limit you can enter")]
        [RegularExpression("^[a-zA-Z'-]+", ErrorMessage = "Please enter a valid Name")]
        public string Description { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter the product price!")]
        [MinLength(1, ErrorMessage = "Minimum is 4 digit")]
        [MaxLength(6, ErrorMessage = "sorry this is higher limit you can enter")]
        [RegularExpression("^[0-9]+", ErrorMessage = "Please enter a valid price")]
        public decimal Price { get; set; }
    }
}
