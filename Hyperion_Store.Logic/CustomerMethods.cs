
using Hyperion_Store.DB.DataProduct;

namespace Hyperion_Store.Logic
{
    public class CustomerMethods : ICustomerOrders 
    {
        public static CustomerMethods _instance { get; set; } = null;
        private CustomerMethods()
        {

        }
        public List<Order> GetAllOrders(Customer customer)
        {
            using(var db = new Electronic_storeContext())
            {
              var list =  db.Orders.Where(c => c.CustomerId == customer.Id).Select(c=>c).ToList();
                return list;    
            }
        }
        public static CustomerMethods GetInstance()//SingleTone Implementation
        {
            if (_instance == null)
            {
                return _instance = new CustomerMethods();
            }
            return _instance;
     


        }
        public static void RestorePassword(string userName,string password)
        {
            using(var db = new Electronic_storeContext())
            {
                var client = db.Customers.Where(c => c.UserName == userName).Select(c => c).FirstOrDefault();
                client.Password = password;
                db.Update(client);
                db.SaveChanges();
                
            };
        }
        public void CreateAccount(string firstname,string lastname,string email,string country, string city, string address,string username,string password)
        {
           
            using (var db = new Electronic_storeContext())
            {

                Customer newCustomer = new Customer()
                {
                    FirstName = firstname,
                    LastName = lastname,
                    Email = email,
                    Country = country,
                    City = city,
                    Adress = address,
                    UserName = username,
                    Password = password

                };
                db.Customers.Add(newCustomer);
                db.SaveChanges();
            }
        }
    }
}