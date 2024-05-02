using FlowCRM.Data;
using FlowCRM.Shared.Entities;
using FlowCRM.Shared.Repositories;
using Microsoft.EntityFrameworkCore;

namespace FlowCRM.Implementations
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Customer>> GetCustomersAsync()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<Customer> GetCustomerAsync(Guid id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                throw new Exception($"No customer found with ID {id}");
            }

            return customer;
        }

        public async Task<Customer> AddCustomerAsync(Customer customer)
        {
            if (customer == null)
            {
                throw new Exception($"No customer found: {customer}");
            }

            customer.CreatedAt = DateTime.Now;
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer> UpdateCustomerAsync(Customer customer)
        {
            var existingCustomer = await _context.Customers.FindAsync(customer.CustomerId);

            if (existingCustomer == null)
            {
                throw new Exception($"No customer found: {customer}");
            }

            existingCustomer.FirstName = customer.FirstName;
            existingCustomer.LastName = customer.LastName;
            existingCustomer.Email = customer.Email;
            existingCustomer.PhoneNumber = customer.PhoneNumber;
            existingCustomer.City = customer.City;
            existingCustomer.Country = customer.Country;
            existingCustomer.UpdatedAt = DateTime.Now;
            existingCustomer.UpdatedBy = customer.UpdatedBy;

            //existingCustomer = customer;
            existingCustomer.UpdatedAt = DateTime.Now;

            _context.Entry(existingCustomer).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return existingCustomer;
        }

        public async Task<Customer> DeleteCustomerAsync(Guid id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer == null)
            {
                throw new Exception($"No customer found with ID {id}");
            }

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return customer;
        }
    }
}
