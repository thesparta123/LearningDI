namespace LearningDI.Interfaces
{
    interface IProducts
    {
        int ItemID { get; set; }
        string ProductName { get; set; }
        string Description { get; set; }
        decimal Price { get; set; }
    }

    interface IItemToPurchase
    {
        int Quantity { get; set; }

        decimal TotalPricePerProduct(int ItemID);        
    }

    interface IProductsRepository
    {
        void AddItem();
        void RemoveItem();
    }
}
