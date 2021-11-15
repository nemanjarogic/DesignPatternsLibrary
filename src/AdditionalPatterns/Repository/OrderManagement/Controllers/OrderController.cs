using System.Collections.Generic;
using OrderManagement.Domain;
using OrderManagement.Infrastructure.Repositories.Contracts;

namespace OrderManagement.Controllers
{
    public class OrderController
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IUnitOfWork _unitOfWork;

        public OrderController(IOrderRepository orderRepository, IUnitOfWork unitOfWork)
        {
            _orderRepository = orderRepository;
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

            newOrder = _orderRepository.Add(newOrder);
            _unitOfWork.Commit();

            return newOrder;
        }

        public IEnumerable<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public Order GetTheMostExpensive()
        {
            return _orderRepository.GetTheMostExpensive();
        }
    }
}
