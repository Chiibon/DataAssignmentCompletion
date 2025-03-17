using DataAssignment.Contexts;
using DataAssignment.Entities;

namespace DataAssignment.Repositories;

public class CustomerRepository(DataContext context) : BaseRepository<CustomerEntity>(context)
{
}