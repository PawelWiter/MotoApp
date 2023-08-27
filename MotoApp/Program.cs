using MotoApp.Entities;
using MotoApp.Repositories;


var employeeRepository = new GenericRepository<Employee>();
employeeRepository.Add(new Employee { FirstName = "Paweł" });
employeeRepository.Add(new Employee { FirstName = "Marek" });
employeeRepository.Add(new Employee { FirstName = "Kasia" });
employeeRepository.Save();
