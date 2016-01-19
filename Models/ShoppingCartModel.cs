using LearningDI.Interfaces;

namespace LearningDI.Models
{
    class ShoppingCartModel : IShoppingCart
    {
        private decimal _taxRate;

        public decimal TaxRate
        {
            get
            {
                return _taxRate;
            }

            set
            {
                _taxRate = value * 0.1m;
            }
        }
    }
}
