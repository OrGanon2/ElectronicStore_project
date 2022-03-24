using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Model;

namespace Hyperion_Store.DB.DataProduct
{
    public partial class Customer : Validation
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Adress { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public static bool ValidateEmail(string email)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
            return Regex.Match(email, pattern).Success;
        }
        public static bool ValidateName(string fullName)
        {
            string IsValidName = @"\D{2,18} \D{2,18}";
            return Regex.Match(fullName, IsValidName).Success;
        }
        public static bool ValidateUserName(string username)
        {
            string pattern = @"^(?=.{8,20}$)(?![.])(?!.*[.]{2})[a-zA-Z0-9.]+(?<![.])$";
            return Regex.Match(username, pattern).Success;
        }
        public static bool ValidatePassword(string password)
        {
            string pattern = @"^(?=[a-zA-Z0-9.]{8,20}$)(?!.*[.]{2})[^.].*[^.]$";
            return Regex.Match(password, pattern).Success;
        }
    }
}
