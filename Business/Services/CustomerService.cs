using Business.Dto;
using Business.Factories;
using Business.Models;
using DataAssignment.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Business.Services;

public class CustomerService(CustomerRepository customerRepository)
{
    private readonly CustomerRepository _customerRepository = customerRepository;
    //Create
    public async Task CreateCustomerAsync(CustomerRegistrationForm form)
    {
        var customerEntity = CustomerFactory.Create(form);
        await _customerRepository.AddAsync(customerEntity!);
    }
    //Read by ID, name
    public async Task<IEnumerable<Customer>> GetCustomersAsync()
    {
        var customerEntities = await _customerRepository.GetAsync();
        return customerEntities.Select(CustomerFactory.Create)!;
    }
    public async Task<Customer?> GetCustomerByIdAsync(int Id)
    {
        var customerEntity = await _customerRepository.GetAsync(x => x.Id == Id);
        return CustomerFactory.Create(customerEntity!);
    }
    public async Task<Customer?> GetCustomerByCustomerNameAsync(string customerName)
    {
        var customerEntity = await _customerRepository.GetAsync(x => x.CustomerName == customerName);
        return CustomerFactory.Create(customerEntity!);
    }
    //Update
    //Delete
}
