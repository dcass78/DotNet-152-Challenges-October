using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    public enum CustomerType { Past, Potential, Present }
    public class Customer
    {
        public CustomerType CustomerType{ get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public Customer(CustomerType customerType, string firstName, string lastName, string email)
        {
            CustomerType = customerType;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
        public Customer()
        {

        }
    

    }





}

