using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FinalProjJC.Models;
using System.Text.Encodings.Web;

namespace FinalProjJC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult DataScience()
        {
            CourseContext context = HttpContext.RequestServices.GetService(typeof(FinalProjJC.Models.CourseContext)) as CourseContext;

            

            return View(context.GetAllCourses());
        }

        public IActionResult CyberSec()
        {
            CourseContext context = HttpContext.RequestServices.GetService(typeof(FinalProjJC.Models.CourseContext)) as CourseContext;

            return View(context.GetAllCyber());
        }

        public IActionResult ProjMgmt()
        {
            CourseContext context = HttpContext.RequestServices.GetService(typeof(FinalProjJC.Models.CourseContext)) as CourseContext;

            return View(context.GetAllProjMgmt());
        }

        public IActionResult SoftwareDev()
        {
            CourseContext context = HttpContext.RequestServices.GetService(typeof(FinalProjJC.Models.CourseContext)) as CourseContext;

            return View(context.GetAllSoftwareDev());
        }

        public IActionResult Networking()
        {
            CourseContext context = HttpContext.RequestServices.GetService(typeof(FinalProjJC.Models.CourseContext)) as CourseContext;

            return View(context.GetAllNetworking());
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
