using BankCMS_.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace BankCMS_.Controllers
{
    public class CustomerController : Controller
    {
        private List<Customer> customers = new List<Customer>
        {
            new Customer { CustomerId = 1, FirstName = "Saleh", LastName = "Bin Essa", Email = "saleh.binessa@example.com", PhoneNumber = "+965 12345678"},
            new Customer { CustomerId = 2, FirstName = "Ahmad", LastName = "Salman", Email = "ahmad.salman@example.com", PhoneNumber = "+965 87654321"}
        };

        public IActionResult Index()
        {
            return View(customers);
        }

        public IActionResult Details(int id)
        {
            var customer = customers.FirstOrDefault(c => c.CustomerId == id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }
    }
}
