﻿using System;

namespace DependencyInjectionExample
{
    // 1. Define Repository Interface
    public interface ICustomerRepository
    {
        string FindCustomerById(int id);
    }

    // 2. Implement Concrete Repository
    public class CustomerRepositoryImpl : ICustomerRepository
    {
        public string FindCustomerById(int id)
        {
            if (id == 1)
                return "Customer: Anshika Agarwal";
            else if (id == 2)
                return "Customer: Archi";
            else
                return "Customer not found";
        }
    }

    // 3. Define Service Class (depends on repository)
    public class CustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public void ShowCustomer(int id)
        {
            Console.WriteLine(_repository.FindCustomerById(id));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ICustomerRepository repo = new CustomerRepositoryImpl();
            CustomerService service = new CustomerService(repo);

            service.ShowCustomer(1); //Anshika Agarwal
            service.ShowCustomer(2); // Archi
            service.ShowCustomer(99); // Customer not found
        }
    }
}