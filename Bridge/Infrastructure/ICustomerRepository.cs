using Bridge.Core.Entities;

namespace Bridge.Infrastructure;

public interface ICustomerRepository
{
    List<Customer> GetBlockedCustomers();
}