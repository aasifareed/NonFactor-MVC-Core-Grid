using FinalMVC6Grid.Enums;
using FinalMVC6Grid.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FinalMVC6Grid.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Int32? page, Int32? rows)
        {

            ViewBag.EmployeeStatusList = SetEnumValues();
        List<EmployeeViewModel> employees = new List<EmployeeViewModel>()
        {
        new EmployeeViewModel {Id = 1, Name = "Julio Avellaneda", Email = "julito_gtu@hotmail.com",EmployeeStatus="Inprogress",DateOfBirth=Convert.ToDateTime("2/1/2021")},
        new EmployeeViewModel {Id = 2, Name = "Juan Torres", Email = "jtorres@hotmail.com",EmployeeStatus="Closed",DateOfBirth=Convert.ToDateTime("2/2/2021") },
        new EmployeeViewModel {Id = 3, Name = "Oscar Camacho", Email = "oscar@hotmail.com",EmployeeStatus="Open",DateOfBirth=Convert.ToDateTime("2/3/2021")},
        new EmployeeViewModel {Id = 4, Name = "Gina Urrego", Email = "ginna@hotmail.com",EmployeeStatus="Inprogress",DateOfBirth=Convert.ToDateTime("2/4/2021") },
        new EmployeeViewModel {Id = 5, Name = "Nathalia Ramirez", Email = "natha@hotmail.com",EmployeeStatus="Inprogress",DateOfBirth=Convert.ToDateTime("2/5/2021") },
        new EmployeeViewModel {Id = 6, Name = "Raul Rodriguez", Email = "rodriguez.raul@hotmail.com",EmployeeStatus="Inprogress",DateOfBirth=Convert.ToDateTime("2/6/2021") },
        new EmployeeViewModel {Id = 7, Name = "Johana Espitia", Email = "johana_espitia@hotmail.com",EmployeeStatus="Inprogress",DateOfBirth=Convert.ToDateTime("2/7/2021") }
          };


            var emp = employees.AsQueryable();
          //  ViewBag.TotalRows = emp.Count();


           // return View(emp.Skip((page - 1 ?? 0) * (rows ?? 3)).Take(rows ?? 3));
            return View(emp);
        }

        private List<SelectListItem> SetEnumValues()
        {
            List<SelectListItem> selectListItems = new List<SelectListItem>();
            foreach (EmployeeStatusEnum employeeStatusEnum in Enum.GetValues(typeof(EmployeeStatusEnum)))
            {
                var employeeStatusDescription = employeeStatusEnum.GetAttribute<DisplayAttribute>();
                 selectListItems.Add(new SelectListItem { Value = employeeStatusDescription.Name, Text = employeeStatusDescription.Description });
            }

            return selectListItems;
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
