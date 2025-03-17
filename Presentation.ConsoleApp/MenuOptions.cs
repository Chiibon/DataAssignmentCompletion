using Business.Factories;
using Business.Services;

namespace Presentation.ConsoleApp;

public class MenuDialogs(CustomerService customerService, ProjectService projectService)
{
    private readonly CustomerService _customerService = customerService;
    private readonly ProjectService _projectService = projectService;

    public async Task MenuOptions()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("--Menu Options--");
            Console.WriteLine("1. Create New Customer");
            Console.WriteLine("2. Create New Project");
            Console.WriteLine("3. Get All Customers");
            Console.WriteLine("4. Get All Projects");
            Console.WriteLine("5. Get Customer");
            Console.WriteLine("6. Get Project");
            Console.WriteLine("7. Update Customer");
            Console.WriteLine("8. Update Project");
            Console.WriteLine("9. Delete Customer");
            Console.WriteLine("10. Delete Project");
            Console.WriteLine("Select Option: ");
            var option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    AddCustomerOption();
                    break;

                case "2":
                    AddProjectOption();
                    break;

                case "3":
                    ViewAllCustomersOption();
                    break;

                case "4":
                    ViewAllProjectsOptions();
                    break;

                case "5":
                    ViewCustomerOption();
                    break;

                case "6":
                    ViewProjectOption();
                    break;

                case "7":
                    UpdateCustomerOption();
                    break;

                case "8":
                    UpdateProjectOption();
                    break;

                case "9":
                    DeleteCustomerOption();
                    break;

                case "10":
                    DeleteProjectOption();
                    break;
            }
        }
    }

    public void DeleteProjectOption() => throw new NotImplementedException();
    public void DeleteCustomerOption() => throw new NotImplementedException();
    public void UpdateProjectOption() => throw new NotImplementedException();
    public void UpdateCustomerOption() => throw new NotImplementedException();
    public void ViewProjectOption() => throw new NotImplementedException();
    public void ViewCustomerOption() => throw new NotImplementedException();
    public void ViewAllProjectsOptions() => throw new NotImplementedException();
    public void ViewAllCustomersOption() => throw new NotImplementedException();
    public void AddProjectOption() => throw new NotImplementedException();
    public void AddCustomerOption()
    {
        var CustomerForm = CustomerFactory.Create();
        Console.Clear();
        Console.WriteLine("-- NEW USER --");
        Console.Write("Name: ");
        CustomerForm.FirstName = Console.ReadLine()!;
        Console.WriteLine();

        var result = _customerService.Save(CustomerForm);
        if (result)
            Console.Write("User was created successfully.");
        else
            Console.WriteLine("User was not created.");
        Console.ReadKey();

    }
}