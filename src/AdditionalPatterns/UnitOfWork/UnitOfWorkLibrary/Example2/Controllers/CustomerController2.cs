using System.Collections.Generic;
using UnitOfWorkLibrary.Domain;
using UnitOfWorkLibrary.Example2.Infrastructure.Repositories.Contracts;

namespace UnitOfWorkLibrary.Example2.Controllers
{
    public class CustomerController2
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController2(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _customerRepository.GetAll();
        }
    }
}
