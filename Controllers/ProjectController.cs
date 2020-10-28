using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Showcase.Data;
using Showcase.Models;

namespace Showcase.Controllers
{
    public class ProjectController : Controller
    {
        private readonly AppDbContext _controllerContext;

        public ProjectController(AppDbContext appDb)
        {
            _controllerContext = appDb;
        }

        public IActionResult Index()
        {
            Console.WriteLine("ONE FROM PROJECT");
            return View(_controllerContext.Project.ToList());
        }
    }
}