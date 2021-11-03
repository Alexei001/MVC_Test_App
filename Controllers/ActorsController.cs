using Microsoft.AspNetCore.Mvc;
using MVC_Test_App.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Test_App.Controllers
{
    public class ActorsController : Controller
    {
        protected readonly ApplicationContext _context;
        public ActorsController(ApplicationContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allActors = _context.Actors.ToList();
            return View(allActors);
        }
    }
}
