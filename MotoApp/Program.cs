using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;


var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext());

employeeRepository.Add(new Employee { FirstName = "Paweł" });
employeeRepository.Add(new Employee { FirstName = "Marek" });
employeeRepository.Add(new Employee { FirstName = "Kasia" });

GetEmployeeById(employeeRepository);

static void GetEmployeeById(IRepository<Employee> employeeRepository)
{
    var employee = employeeRepository.GetById(2);
    Console.WriteLine(employee.ToString());
}