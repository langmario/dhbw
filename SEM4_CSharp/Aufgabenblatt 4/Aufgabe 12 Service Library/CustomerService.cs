using Aufgabe_12_Service_Library.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Aufgabe_12_Service_Library
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class CustomerService : ICustomerService
    {
        private List<Customer> mCustomers = new List<Customer>()
        {
            new Customer
            {
                FirstName = "John",
                LastName = "Doe",
                IsPremiumCustomer = true
            },
            new Customer
            {
                FirstName = "Jane",
                LastName = "Doe",
                IsPremiumCustomer = false
            }
        };

        public bool AddCustomer(Customer customer)
        {
            if (mCustomers.Find(customer.Equals) != null)
            {
                return false;
            }

            mCustomers.Add(customer);
            return true;
        }

        public List<Customer> GetAllCustomers()
        {
            return mCustomers;
        }

        public List<Customer> GetCustomers(string search)
        {
            return mCustomers.Where(c => c.LastName == search).ToList();
        }

        public bool RemoveCustomer(Customer customer)
        {
            return mCustomers.Remove(customer);
        }
    }
}
