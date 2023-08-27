using MotoApp.Data;
using MotoApp.Entities;
using MotoApp.Repositories;


//var employeeRepository = new GenericRepository<Employee>();
//employeeRepository.Add(new Employee { FirstName = "Paweł" });
//employeeRepository.Add(new Employee { FirstName = "Marek" });
//employeeRepository.Add(new Employee { FirstName = "Kasia" });
//employeeRepository.Save();

var sqlRepository = new SqlRepository(new MotoAppDbContext());

sqlRepository.Add(new Employee { FirstName = "Paweł" });
sqlRepository.Add(new Employee { FirstName = "Marek" });
sqlRepository.Add(new Employee { FirstName = "Kasia" });

sqlRepository.Save();
var emp = sqlRepository.GetById(1);
Console.WriteLine(emp.ToString());