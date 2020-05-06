﻿using Aufgabe_12_Service_Library.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Aufgabe_12_Service_Library
{
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        bool AddCustomer(Customer customer);
        [OperationContract]
        bool RemoveCustomer(Customer customer);
        [OperationContract]
        List<Customer> GetAllCustomers();
        [OperationContract]
        List<Customer> GetCustomers(string search);
    }
}
