using System.Collections.Generic;
using UnitOfWorkLibrary.Domain;
using UnitOfWorkLibrary.Example1.Infrastructure;

namespace UnitOfWorkLibrary.Example1.Controllers
{
    public class OrderController1
    {
        private readonly IUnitOfWork1 _unitOfWork;

        public OrderController1(IUnitOfWork1 unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Order Create(int id, string description, string deliveryAddress, decimal price)
        {
            // ID is usually auto-genereated by database.
            var newOrder = new Order()
            {
                Id = id,
                Description = description,
                DeliveryAddress = deliveryAddress,
                Price = price,
            };

            newOrder = _unitOfWork.OrderRepository.Add(newOrder);
            // _unitOfWork.CustomerRepository.Add(new Customer() { Id = 33 });

            // In this example we work only with order repository,
            // but it would be possible to create/update different entities by using
            // different repositories and save all changes via unit of work instance.
            _unitOfWork.SaveChanges();

            return newOrder;
        }

        public IEnumerable<Order> GetAll()
        {
            return _unitOfWork.OrderRepository.GetAll();
        }
    }
}
