using System.Collections.Generic;
using UnitOfWorkLibrary.Domain;
using UnitOfWorkLibrary.Example1.Infrastructure;

namespace UnitOfWorkLibrary.Example1.Controllers
{
    public class CustomerController1
    {
        private readonly IUnitOfWork1 _unitOfWork;

        public CustomerController1(IUnitOfWork1 unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Customer> GetAll()
        {
            return _unitOfWork.CustomerRepository.GetAll();
        }
    }
}
