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


        [HttpGet]
        [Route("/Project/ProjectDetails/{projectId}")]
        public IActionResult ProjectDetails(int projectId)
        {
            // C ProjectDetails pd = new uProjectDetails();
            Console.WriteLine(projectId);
            List<ProjectModel> allInfo = new List<ProjectModel>(
                            _controllerContext.Project.
                            Where(x => x.Id == projectId).
                            Include(project => project.Builder).
                            Include(project => project.Address).
                            ToList());

                        
            List<UnitsModel> unitsForProject = new List<UnitsModel>(_controllerContext.Units.Where(x => x.projectId == projectId));
            allInfo.ForEach(Console.WriteLine);
            
            // will pass info to view
            return View("Detail", new Showcase.Models.Custom.ProjectDetails { UnitsList = unitsForProject, ProjectRecord = allInfo[0] });
        }

        [HttpGet]
        [Route("/Project/UnitDetails/{unitId}")]
        public IActionResult UnitDetails(int unitId)
        {
            Console.WriteLine("unit detail action called");            
            Console.WriteLine($"UNIT ID IS.. {unitId}");
            var unit = _controllerContext.Units.FirstOrDefault( x => x.Id == unitId);
            return View("UnitInfo",unit);
        }
    }
}