using Bridge.Core.Enums;

namespace Bridge.Infrastructure.Payments;

public interface IPaymentServiceFactory
{
    IPaymentService GetService(PaymentMethod paymentMethod);
}