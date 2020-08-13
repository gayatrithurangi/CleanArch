using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CleanArch.UI.Mvc.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        //Adding coursecontroller Constructor  
        private ICourseService _courseService;


      
        //Dependency Inject Interface(Service) into the Controller using constrictor
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            CourseViewModel model = _courseService.GetCourses();
            return View(model);
        }



    }
}
