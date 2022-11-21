﻿using System.Collections.Generic;

namespace CustomerRegister.Repositories.Interfaces
{
    public interface ICustomerService
    {
        List<CustomerEntity> SearchAllCustomers();
        CustomerEntity SearchCustomerById(int id);
        int AddCustomer(CustomerEntity customer);
        void UpdateCustomer(CustomerEntity customer, int id);
        bool DeleteCustomer(int id);

    }
}
