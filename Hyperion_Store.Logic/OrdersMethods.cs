
using Hyperion_Store.DB.DataProduct;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Hyperion_Store.Logic
{
    public class OrdersMethods : ICustomerOrders , IOrders
    {
        public Order CreateOrderInstance(int itemID,Customer ThisCustomer,string _product)
        {
            using (var db = new Electronic_storeContext())
            {
               
                if (_product.ToLower() == "laptop")
                {
                    var id = Convert.ToInt32(itemID);
                    var product = db.Laptops.Where(c => c.Id == id).Select(c => c).FirstOrDefault();
                    Order order = new Order()
                    {
                        FirstName = ThisCustomer.FirstName,
                        LastName = ThisCustomer.LastName,
                        CustomerId = ThisCustomer.Id,
                        Amount = product.Price,
                        OrderedProduct = product.Laptop1.ToString(),
                    };
                    var customer = db.Customers.Where(c => c.Id == ThisCustomer.Id).Select(c => c).FirstOrDefault();
                    customer.Orders.Add(order);
                    db.Orders.Add(order);
                    db.SaveChanges();
                    return order;
                };
                if(_product.ToLower() == "computer")
                {
                    var id = Convert.ToInt32(itemID);
                    var product = db.Computers.Where(c => c.Id == id).Select(c => c).FirstOrDefault();
                    Order order = new Order()
                    {
                        FirstName = ThisCustomer.FirstName,
                        LastName = ThisCustomer.LastName,
                        CustomerId = ThisCustomer.Id,
                        Amount = product.Price,

                        OrderedProduct = product.Computer1.ToString(),
                    };
                    var customer = db.Customers.Where(c => c.Id == ThisCustomer.Id).Select(c => c).FirstOrDefault();
                    customer.Orders.Add(order);
                    db.Orders.Add(order);
                    db.SaveChanges();
                    return order;
                }
                if (_product.ToLower() == "monitor")
                {
                    var id = Convert.ToInt32(itemID);
                    var product = db.Monitors.Where(c => c.Id == id).Select(c => c).FirstOrDefault();

                    Order order = new Order()
                    {
                        FirstName = ThisCustomer.FirstName,
                        LastName = ThisCustomer.LastName,
                        CustomerId = ThisCustomer.Id,
                        Amount = product.Price,
                        OrderedProduct = product.Monitor1.ToString(),
                    };
                    var customer = db.Customers.Where(c => c.Id == ThisCustomer.Id).Select(c => c).FirstOrDefault();
                    customer.Orders.Add(order);
                    db.Orders.Add(order);
                    db.SaveChanges();
                    return order;
                }
                if(_product.ToLower() == "phone")
                {
                    var id = Convert.ToInt32(itemID);
                    var product = db.Phones.Where(c => c.Id == id).Select(c => c).FirstOrDefault();

                    Order order = new Order()
                    {
                        FirstName = ThisCustomer.FirstName,
                        LastName = ThisCustomer.LastName,
                        CustomerId = ThisCustomer.Id,
                        Amount = product.Price,
                        OrderedProduct = product.Phone1.ToString(),
                    };
                    var customer = db.Customers.Where(c => c.Id == ThisCustomer.Id).Select(c => c).FirstOrDefault();
                    customer.Orders.Add(order);
                    db.Orders.Add(order);
                    db.SaveChanges();
                    return order;
                }
                else
                {
                    return null;
                    Debug.WriteLine("nothing has been chosen");
                }
                
            }

               
                
        }//Factory Methods

        public List<Order> GetAllOrders(Customer customer)
        {
            using (var db = new Electronic_storeContext())
            {
                var list = db.Orders.Where(c => c.CustomerId == customer.Id).Select(c => c).ToList();
                return list;
            }
        }

        public List<Order> GetThisCustomerOrders(Customer customer)
        {
            using (var db = new Electronic_storeContext())
            {
                var list = db.Orders.Where(c => c.CustomerId == customer.Id).Select(customer => customer).ToList();
                return list;
            };
        }

        public void RemoveOrdersByID(List<Order> orderList)
        {
           using(var db = new Electronic_storeContext())
           {
                foreach (var item in orderList)
                {
                   var orderRemove =  db.Orders.Where(c => c.Id == item.Id).Select(c => c).First();
                    db.Orders.Remove(orderRemove);
                    db.SaveChanges();

                }

           };
        }
    }
}
