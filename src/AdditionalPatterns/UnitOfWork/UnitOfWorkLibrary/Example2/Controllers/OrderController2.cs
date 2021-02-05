using System.Collections.Generic;
using System.Threading.Tasks;
using UnitOfWorkLibrary.Domain;
using UnitOfWorkLibrary.Example2.Infrastructure.Repositories.Contracts;

namespace UnitOfWorkLibrary.Example2.Controllers
{
    public class OrderController2
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController2(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Order> CreateAsync(int id, string description, string deliveryAddress, decimal price)
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
            await _orderRepository.UnitOfWork.SaveChangesAsync();

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
