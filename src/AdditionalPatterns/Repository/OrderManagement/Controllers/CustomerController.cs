using System.Collections.Generic;
using OrderManagement.Domain;
using OrderManagement.Infrastructure.Repositories.Contracts;

namespace OrderManagement.Controllers
{
    public class CustomerController
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }
    }
}
