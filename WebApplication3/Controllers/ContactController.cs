using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.ViewModels;

namespace WebApplication3.Controllers
{
    public class ContactController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 2", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 3", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 4", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 5", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 6", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 7", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 8", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 9", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 10", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 11", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 12", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 13", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 14", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 15", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 16", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 17", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 18", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 19", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 20", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 21", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 22", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 23", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 24", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" },
                new Customer {Name = "Customer 25", Email = "john.doe@gmail.com", Phone = "210-555-555", Address = "123 abc road", Notes = "This is a test" }
            
            };

            var viewModel = new ContactViewModel
            {
          
                Customers = customers
            };

              return View(viewModel);
        }
    }
}