using Bridge.Application.Models;

namespace Bridge.Infrastructure.Deliveries;

public interface IDeliveryService
{
    void Deliver(OrderInputModel model);
}