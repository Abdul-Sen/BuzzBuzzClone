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
    public class UserController : Controller
    {
        private readonly AppDbContext _controllerContext;

        public UserController(AppDbContext appDb)
        {
            _controllerContext = appDb;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewUser(UserModel UM){
            // Console.WriteLine("hello can anyone read this????????????????");
            Console.WriteLine("TEST 2");
            Console.WriteLine(UM.ToString());
            _controllerContext.Add(UM);
            _controllerContext.SaveChanges();
            ViewBag.message = "User " + UM.Name + " added to DB";
            return Redirect("~/HomeController/Index");
        }
    }
}