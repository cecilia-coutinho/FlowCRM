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


        public async Task<IEnumerable<Customer>> GetCustomersAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 1000)
        {
            var customers = _context.Customers.AsQueryable();

            // Filter
            if (!string.IsNullOrWhiteSpace(filterOn) && !string.IsNullOrWhiteSpace(filterQuery))
            {
                if (filterOn.Equals("FirstName", StringComparison.OrdinalIgnoreCase))
                {
                    customers = customers.Where(c => c.FirstName != null && c.FirstName.Contains(filterQuery));
                }
                else if (filterOn.Equals("LastName", StringComparison.OrdinalIgnoreCase))
                {
                    customers = customers.Where(c => c.LastName != null && c.LastName.Contains(filterQuery));
                }
                else if (filterOn.Equals("Email", StringComparison.OrdinalIgnoreCase))
                {
                    customers = customers.Where(c => c.Email != null && c.Email.Contains(filterQuery));
                }
                else if (filterOn.Equals("PhoneNumber", StringComparison.OrdinalIgnoreCase))
                {
                    customers = customers.Where(c => c.PhoneNumber != null && c.PhoneNumber.Contains(filterQuery))
                    ;
                }
                else if (filterOn.Equals("City", StringComparison.OrdinalIgnoreCase))
                {
                    customers = customers.Where(c => c.City != null && c.City.Contains(filterQuery));
                }
                else if (filterOn.Equals("Country", StringComparison.OrdinalIgnoreCase))
                {
                    customers = customers.Where(c => c.Country != null && c.Country.Contains(filterQuery));
                }
            }

            // Sort
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                if (sortBy.Equals("FirstName", StringComparison.OrdinalIgnoreCase))
                {
                    customers = isAscending ? customers.OrderBy(c => c.FirstName) : customers.OrderByDescending(c => c.FirstName);
                }
                else if (sortBy.Equals("LastName", StringComparison.OrdinalIgnoreCase))
                {
                    customers = isAscending ? customers.OrderBy(c => c.LastName) : customers.OrderByDescending(c => c.LastName);
                }
                else if (sortBy.Equals("Email", StringComparison.OrdinalIgnoreCase))
                {
                    customers = isAscending ? customers.OrderBy(c => c.Email) : customers.OrderByDescending(c => c.Email);
                }
                else if (sortBy.Equals("PhoneNumber", StringComparison.OrdinalIgnoreCase))
                {
                    customers = isAscending ? customers.OrderBy(c => c.PhoneNumber) : customers.OrderByDescending(c => c.PhoneNumber);
                }
                else if (sortBy.Equals("City", StringComparison.OrdinalIgnoreCase))
                {
                    customers = isAscending ? customers.OrderBy(c => c.City) : customers.OrderByDescending(c => c.City);
                }
                else if (sortBy.Equals("Country", StringComparison.OrdinalIgnoreCase))
                {
                    customers = isAscending ? customers.OrderBy(c => c.Country) : customers.OrderByDescending(c => c.Country);
                }
            }

            // Pagination
            var skipResults = (pageNumber - 1) * pageSize;

            return await customers.Skip(skipResults).Take(pageSize).ToListAsync();
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
            await _context.Customers.AddAsync(customer);
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
            //existingCustomer.UpdatedAt = DateTime.Now;

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
