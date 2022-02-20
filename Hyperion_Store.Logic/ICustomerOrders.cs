using Hyperion_Store.DB.DataProduct;

namespace Hyperion_Store.Logic
{
    public interface ICustomerOrders 
    {
        List<Order> GetAllOrders(Customer customer);
       
    }
}