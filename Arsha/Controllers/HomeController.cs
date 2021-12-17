using Arsha.Models;
using Arsha.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Arsha.Controllers
{
    public class HomeController : Controller
    {

        private DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }
      

        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Clients = _context.Clients.ToList(),
                Services = _context.Services.ToList(),
                Portfolios = _context.Portfolios.Include(x=>x.portfolioImages).ToList(),
                Categories=_context.Categories.ToList()

            };   
            return View(homeVM);
        }
        public IActionResult PortFolioDetail()
        {
            return View();
        }

        

        
       
    }
}
