using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace nova_blog.Controllers
{
    public class EmployeesController : Controller
    {
        private ISanityConnector _sanityConnector;

        public EmployeesController(ISanityConnector sanityConnector)
        {
            _sanityConnector = sanityConnector;
        }
        public async Task<IActionResult> Index()
        {
            var employees = await _sanityConnector.Get<Employee>("{name, position, bio, 'imageUrl':image.asset->url}");
            return View(employees.ToList());
        }
    }
}
