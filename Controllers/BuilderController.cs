using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Showcase.Data;
using Showcase.Models;
using Microsoft.EntityFrameworkCore;


namespace Showcase.Controllers
{
    public class BuilderController : Controller
    {
        private readonly AppDbContext _controllerContext;

        public BuilderController(AppDbContext appDb)
        {
            _controllerContext = appDb;
        }

        public IActionResult Index()
        {
            return View(_controllerContext.Builder.ToList());
        }

        [HttpGet]
        [Route("/Builder/Edit/{builderId}")]
        public IActionResult Edit(int builderId)
        {
            return View(_controllerContext.Builder.FirstOrDefault(x => x.Id == builderId));
        }

        [HttpPost]
        public IActionResult Edit(BuilderModel bm)
        {
            Console.WriteLine("Edit post method called");
            _controllerContext.Builder.Update(bm);
            _controllerContext.SaveChanges();
            return Redirect("~/Builder/Index");
        }

        public IActionResult Create(){
            return View();
        }

        [HttpPost]
        public IActionResult Create(BuilderModel bm){
            _controllerContext.Builder.Add(bm);
            _controllerContext.SaveChanges();

            return Redirect("~/Builder/Index");
        }
        
        [HttpGet]
        [Route("/Builder/Delete/{id}")]
        public IActionResult Delete(int id)
        {
            // todo - delete
            BuilderModel bm = _controllerContext.Builder.FirstOrDefault(x => x.Id == id );
            _controllerContext.Builder.Remove(bm);
            _controllerContext.SaveChanges();

            return Redirect("~/Builder/Index");   
        }


        [HttpGet]
        [Route("/Builder/BuilderProjects/{builderId}")]
        public IActionResult BuilderProjects(int builderId)
        {
            Console.WriteLine("Builder projects called with id: " + builderId);
            // get builder
            BuilderModel bm = _controllerContext.Builder.FirstOrDefault(x => x.Id == builderId);
            // select * from projects where BuilderId == 1000; //Lambda Linq
            List<ProjectModel> projectList = _controllerContext.Project.Where(project => project.BuilderId == bm.Id).ToList();
            Showcase.Models.Custom.BuilderProjects builderProjects = new Models.Custom.BuilderProjects() { builder = bm, projects = projectList };
            return View("BuilderProjects", builderProjects);
        }
        
    }
}
