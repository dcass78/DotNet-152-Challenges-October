using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    public class GreetRepository
    {
        List<Customer> _customerList = new List<Customer>();
        public void AddCustomer(Customer list)
        {
            _customerList.Add(list);
        }
        public void RemoveCustomerFromList(Customer removeCustomer)
        {
            _customerList.Remove(removeCustomer);
        }
        public void UpdateCustomer(Customer updateCustomer)
        {
            //_customerList.Update(updateCustomer);
        }
        public List<Customer> GetCustomerList()
        {
            _customerList.Sort((x, y) => string.Compare(x.LastName, y.LastName));

            return _customerList;
        }


    }
}  
