

using Hyperion_Store.DB.DataProduct;
using System.Collections.Generic;

namespace Hyperion_Store.Logic
{
   public interface IOrders
    {
        Order CreateOrderInstance(int ItemID, Customer ThisCustomer, string product);
        void RemoveOrdersByID(List<Order> orderList);
        List<Order> GetThisCustomerOrders(Customer customer);
    }
}