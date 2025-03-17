using System.Linq.Expressions;
using DataAssignment.Entities;

namespace Business.Interfaces;

public interface ICustomerService
{
    Task<CustomerEntity> CreateAsync(CustomerEntity customer);
    Task<IEnumerable<CustomerEntity>> GetAllAsync();
    Task<CustomerEntity> GetAsync(Expression<Func<CustomerEntity, bool>> expression);
    Task<CustomerEntity> UpdateAsync(CustomerEntity customer);
    Task<bool> DeleteAsync(Expression<Func<CustomerEntity, bool>> expression);

}

