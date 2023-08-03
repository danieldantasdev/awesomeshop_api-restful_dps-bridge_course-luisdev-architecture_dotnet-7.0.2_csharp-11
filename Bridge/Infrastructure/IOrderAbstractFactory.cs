using Bridge.Core.Enums;
using Bridge.Infrastructure.Deliveries;
using Bridge.Infrastructure.Payments;

namespace Bridge.Infrastructure;

public interface IOrderAbstractFactory
{
    IPaymentService GetPaymentService(PaymentMethod method);
    IDeliveryService GetDeliveryService();
}