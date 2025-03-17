using DataAssignment.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAssignment.Contexts;

public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    public DbSet<CustomerEntity> Customers { get; set; }
    public DbSet<ProjectEntity> Projects { get; set; }
}
