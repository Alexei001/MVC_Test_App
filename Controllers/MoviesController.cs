using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Test_App.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Test_App.Controllers
{
    public class MoviesController : Controller
    {
        protected readonly ApplicationContext _context;

        public MoviesController(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var allMovies = await _context.Movies.ToListAsync();
            return View();
        }
    }
}
