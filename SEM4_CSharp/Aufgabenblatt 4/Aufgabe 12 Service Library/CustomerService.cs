﻿using Aufgabe_12_Service_Library.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace Aufgabe_12_Service_Library
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class CustomerService : ICustomerService
    {
        private List<Customer> mCustomers = new List<Customer>()
        {
            new Customer
            {
                FirstName = "Jens",
                LastName = "Mander",
                IsPremiumCustomer = true
            },
            new Customer
            {
                FirstName = "Hans",
                LastName = "Wurst",
                IsPremiumCustomer = false
            },
            new Customer
            {
                FirstName = "Guybrush",
                LastName = "Threepwod",
                IsPremiumCustomer = true
            }
        };

        public bool AddCustomer(Customer customer)
        {
            if (mCustomers.Contains(customer))
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
            return mCustomers.Where(c => c.LastName.StartsWith(search, StringComparison.InvariantCultureIgnoreCase)).ToList();
        }

        public bool RemoveCustomer(Customer customer)
        {
            return mCustomers.Remove(customer);
        }
    }
}
