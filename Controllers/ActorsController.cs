using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Test_App.Data.Services;
using MVC_Test_App.Models;
using MVC_Test_App.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Test_App.Controllers
{
    public class ActorsController : Controller
    {
        protected readonly IActorsService _service;
        public ActorsController(IActorsService service)
        {
            this._service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allActors = await _service.GetAll();
            return View(allActors);
        }

        public IActionResult Create()
        {

            return View();
        }
    }
}
