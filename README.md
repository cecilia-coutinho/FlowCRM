<h1 align="center">CRM Blazor WASM 📈💻⚡ </h1>

<p align = center>
by <a href="https://github.com/Cecilia-Coutinho">Cecilia Coutinho</a>
</p>

## 🌍 Overview

This project is a simplified Customer Relationship Management (CRM) system designed specifically for small businesses. The goal is to create a streamlined and user-friendly application, without the complexities often associated with larger CRM solutions. This project demonstrates the feasibility of a simplified CRM tool, designed to be efficiently managed and implemented by individual developers.

## 🚀 MVP Features

✅ User Authentication: Implementation of user authentication via Identity.

✅ Intuitive Navigation: Integration of an intuitive and user-friendly navigation.

✅ Customer Management: Enable creation and management of customers.

✅ Company Management: Enable creation and management of companies.

✅ Contact Management: Enable creation and management of contacts.

✅ Deal Tracking: Enable creation and management of deals, including assigning them to customers, tracking deal status, value, and priorities.

✅ Lead Management: Capture and track leads, including lead source, contact information, and status in the sales pipeline.

✅ Activity Tracking: Log activities such as calls, meetings, and emails related to customers, deals, and leads.

✅ Priority Management: Provision of priority levels for deals and leads.


## 💻 Technology Stack

* .NET 8 

* ASP.NET Web API

* Blazor WebAssembly

* C#

* SQL Server Management Studio (SSMS)

* Entity Framework

* Visual Studio

* GitHub


## 📋 Additional Information

### SQL Design

The SQL design follows a relational database model, with tables representing entities such as Users, Customers, Companies, Contacts, Deals, Leads, Activities, DealsStatus, Priorities and ActivitiesType. These tables handle tasks such as user authentication, customer information, company details, contact records, deal tracking, lead management, activity logging, deal status tracking, priority management, and activity categorization. Relationships are established using foreign keys to maintain data integrity.

![ER Model](/FlowCRM/FlowCRM/FlowCRM/images/Db-Diagram.png)


### Code Structure

This project is set up to work as a Single Page Application (SPA) using ASP.NET on the server side and Blazor on the client side. The structure keeps the code organized and makes it easier to work on different parts of the project.

On the server-side, tasks include managing user accounts, transferring SQL data, and handling client requests.

The logic is structured around nine main controllers: Customers, Companies, Contacts, Deals, Leads, Activities, DealsStatus, Priorities and ActivitiesType. The project is structured with specific folders for managing the database context, implementing the repository pattern, handling data management, and applying Action Filters.

![Code Structure 1](/FlowCRM/FlowCRM/FlowCRM/images/code-structure_server-side.PNG)

The client-side manages the creation of an interactive and dynamic user interface while initiating requests to the server-side. It is organized with specific folders for components, pages, and services.

![Code Structure 2](/FlowCRM/FlowCRM/FlowCRM/images/code-structure_client-side.PNG)

Additionally, there is a shared library used by both server and client sides. These components manage functionalities such as entities and interfaces.

![Code Structure 3](/FlowCRM/FlowCRM/FlowCRM/images/code-structure_shared.PNG)

#### Seed Data

Seed Data was implemented to provide a set of information that is automatically inserted into the database during application initialization or migration. This ensures a starting point for testing and application functionality. The implementation utilizes Entity Framework Core's ModelBuilder to seed data into entities. The following code snippet demonstrates the seeding of customer data:

```
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
            new Customer
            {
                CustomerId = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                PhoneNumber = "123456789",
                City = "New York",
                Country = "USA",
                CreatedAt = DateTime.Now
            },

            ...
        }
```

Can be found in the `FlowCRM/FlowCRM/FlowCRM/Data/ModelBuilderExtension.cs` file.

### User Authentication

User authentication is implemented using Identity feature within .NET 8. Future improvements could include adding roles and permissions to manage user access levels and restrict certain functionalities based on user roles. For now this feature is not implemented.

### Repository Pattern

The repository pattern is implemented to manage data access and abstract the data source. This pattern allows for separation of concerns and provides a more organized and efficient way to handle data. The implementation includes interfaces for each repository that handles common CRUD operations. This pattern ensures that the data access layer is decoupled from the business logic layer, making it easier to maintain and test the application.

The following code snippet demonstrates the repository pattern implementation for the Customer entity:

```
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
                ...
            }

            // Sort
            if (!string.IsNullOrWhiteSpace(sortBy))
            {
                ...
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
            ...

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

```

Can be found in the `FlowCRM/FlowCRM/FlowCRM/Implementations/CustomerRepository.cs` file.

   #### Interfaces

   The implementation includes interfaces for each repository. The following code snippet demonstrates the interface implementation for the Customer repository:

    ```
	    public interface ICustomerRepository
	    {
            Task<IEnumerable<Customer>> GetCustomersAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool isAscending = true, int pageNumber = 1, int pageSize = 10);
		    Task<Customer> GetCustomerAsync(Guid id);
		    Task<Customer> AddCustomerAsync(Customer customer);
		    Task<Customer> UpdateCustomerAsync(Customer customer);
		    Task<Customer> DeleteCustomerAsync(Guid id);
	    }
    ```

Can be found in the `FlowCRM/FlowCRM/FlowCRM.Shared/Repositories/ICustomerRepository.cs` file.

### Action Filters

Action filters are implemented to perform additional logic before or after an action method is executed. This allows for common logic to be applied across multiple controllers and action methods. The implementation needs to be refactored to improve functionalities and make it more robust.

The following code snippet illustrates the current implementation of the action filter:

```
    public class ValidateModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                context.Result = new BadRequestObjectResult(new CustomErrorResult
                {
                    Succeeded = false,
                    Errors = context.ModelState.Values.SelectMany(
                                o => o.Errors.Select(
                                    e => e.ErrorMessage))
                });

            }

            base.OnActionExecuting(context);
        }
    }
```

```
{
    public class CustomErrorResult
    {
        public bool Succeeded { get; set; }
        public IEnumerable<string>? Errors { get; set; }
    }
```

Can be found in the `FlowCRM/FlowCRM/FlowCRM/CustomActionFilters/` folder.

### Components

This project has components that are reusable pieces of code that can be shared across different parts of the application. They help to keep the code organized and make it easier to maintain and update the application. Refactoring is still needed to improve and use components that can help to reduce code duplication and improve the overall structure of the application.

Both the server and client sides have components that are used to display data, handle user input, and interact with the application. These components are organized into folders based on their functionality and purpose.

The following code snippet demonstrates the implementation of a component that displays customer information:

```
@if (IsModalVisible)
{
    <div class="modal" tabindex="-1" style="display:block">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <h5 class="modal-title">Customer Details</h5>
                    <button type="button" class="btn-close" @onclick="CloseModal"></button>
                </div>
                <div class="modal-body">
                    <form @onsubmit="HandleSubmit">
                        <div class="form-group mb-3">
                            <label for="FirstName">First Name</label>
                            <input type="text" class="form-control" id="FirstName" @bind="Customer.FirstName">
                        </div>
                        <div class="form-group mb-3">
                            <label for="LastName">Last Name</label>
                            <input type="text" class="form-control" id="LastName" @bind="Customer.LastName">
                        </div>
                        ...

                        @if (Mode != "view")
                        {
                            <button type="submit" class="btn btn-primary mb-3">Save Changes</button>
                        }
                    </form>
                </div>
            </div>
        </div>
    </div>
}

@code {
    [Parameter]
    public Customer Customer { get; set; }

    [Parameter]
    public EventCallback<Customer> OnSubmit { get; set; }

    [Parameter]
    public bool IsModalVisible { get; set; }

    [Parameter]
    public string? Mode { get; set; }

    [Parameter]
    public EventCallback<bool> IsModalVisibleChanged { get; set; }

    private async Task HandleSubmit()
    {
        if (OnSubmit.HasDelegate)
        {
            await OnSubmit.InvokeAsync(Customer);
        }
    }

    private async Task CloseModal()
    {
        await IsModalVisibleChanged.InvokeAsync(false);
    }
}

```

Can be found in the `FlowCRM/FlowCRM/FlowCRM.Client/Components/CustomerForm.razor` file.

### Validation

Validation is implemented to prevent invalid data from being stored in the database. The validation model is implemented using Data Annotations and are used to define validation rules directly in the model class. The implementation includes validation rules for required fields and can be improved to use data.

The following code snippet demonstrates the current validation model for the Customer entity:

```
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; }

        [Required]
        public string? FirstName { get; set; }

        [Required]
        public string? LastName { get; set; }

        [Required]
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        // Navigation properties
        [JsonIgnore]
        public ICollection<Contact>? Contacts { get; set; }
        [JsonIgnore]
        public ICollection<Deal>? Deals { get; set; }

    }
```


And the following code snippet demonstrates how the validation model can be refactored for improvements later on. In this example the model adds custom error messages for required fields, validates email format, limits the length of certain fields, and makes FirstName, LastName, and Email non-nullable:

```
    public class Customer
    {
        [Key]
        public Guid CustomerId { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [MaxLength(10, ErrorMessage = "Phone Number must be 10 digits")]
        public string PhoneNumber { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [MaxLength(50)]
        public string Country { get; set; }

        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        // Navigation properties
        [JsonIgnore]
        public ICollection<Contact>? Contacts { get; set; }
        [JsonIgnore]
        public ICollection<Deal>? Deals { get; set; }

    }
```

The **required modifier** is a feature tha could be applied in this project to tell the C# compiler that these properties must be initialized whenever a new Customer object is created, but it was not implemented. 

The **required modifier** can be used as follows and can also be used for future improvements to make sure required properties are always set. This is useful to avoid forgetting to initialize a property that always needs to be initialized. The **required modifier** can help catch these kinds of errors early on in the development process.

```
    public class Customer
    {
        [Key]
        ...
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        ...

    }
```

### Future Improvements

Future improvements could include adding roles and permissions to manage user access levels and restrict certain functionalities based on user roles to ensure only authorized users can access and modify certain parts of the application. This can be done implementing [Authorize] attributes to enforce authorization rules on both the API and client sides

```
    [Authorize(Roles = "Admin")]
    public class CustomersController : ControllerBase
    {
        ...
    }
```

Additionally, the validation model can be improved to use data annotations to define validation rules directly in the model class.

```
    [MaxLength(10, ErrorMessage = "Phone Number must be 10 digits")]
    public string PhoneNumber { get; set; }
```

Some other improvements that could be made to the project include adding more features such as:

    🌟 Ability to upload files

    🌟 Calendar integration

    🌟 Send emails

    🌟 Support case management 

    🌟 Integration with other services

These features could be implemented using third-party libraries or APIs to extend the functionality of the application. Those improvements are something I have in mind to explore better and implement while working on this project.

### Conclusion

In conclusion, this project uses Blazor WASM to create an interactive Single Page Application (SPA). The design incorporates distinct server-side controllers, a repository pattern implementation, and shared components, ensuring efficient data handling and an engaging user experience.

 There are areas for potential improvements, such as refactoring to implement better DRY principles to avoid code redundancy. Additionally, enhancing the validation model would strengthen data integrity. On the client-side, further enhancements, such as adding roles and permissions, would improve user access control as well as implementing more features to extend the application's functionality and improve the UI for a better user experience.
 
 These aspects present potential areas for future development and the current implementation demonstrates basic functionalities for a simplified CRM system.

