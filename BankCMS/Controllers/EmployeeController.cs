using BankCMS_.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankCMS_.Controllers
{
    public class EmployeeController : Controller
    {
           private List<Employee> employees = new List<Employee>
    {
        new Employee { EmployeeId = 1, FirstName = "Saleh", LastName = "Bin Essa", Department = "IT", Email = "saleh.binessa@gmail.com"},
        new Employee { EmployeeId = 2, FirstName = "Nawaf", LastName = "Almutairi", Department = "IT", Email = "nawaf.almutairi@gmail.com"},
    };
        public IActionResult Index()
        {
            return View(employees);
        }

        public IActionResult EmployeeDetails(int id)
        {
            var employee = employees.FirstOrDefault(e => e.EmployeeId == id);

            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }
    }
}
