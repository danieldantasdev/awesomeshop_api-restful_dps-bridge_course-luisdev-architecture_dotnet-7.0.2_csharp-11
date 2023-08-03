using Bridge.Application.Models;

namespace Bridge.Infrastructure.Payments;

public interface IPaymentService
{
    object Process(OrderInputModel model);
}