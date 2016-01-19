namespace LearningDI.Interfaces
{
    interface ICustomer
    {
        int CustomerID { get; set; }
        string Name { get; set; }
        string EmailID { get; set; }
        string PhoneNumber { get; set; }       
        
    }

    interface ICustomerMethods
    {
        void AddCustomer(ICustomer customer);
        void getCustomer(int customerID);
        void getDiscount();
    }
    interface IPreferredCustomer: ICustomer
    {
        string Status { get; set; }
        void getGoodDiscount();
    }
}
