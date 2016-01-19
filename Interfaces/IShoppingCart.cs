namespace LearningDI.Interfaces
{
    interface IShoppingCart
    {
        decimal TaxRate { get; set; }        
    }

    interface IShoppingCartMethods
    {
        void CalculateTotal();
    }
    interface IShoppingCartRepository
    {
        void PlaceOrder();
        void CancelOrder();
    }
}
