using DependenyInjectionDemo.InfraStructure;
using DependenyInjectionDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace DependenyInjectionDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly IStudentRepo _repo;
        public HomeController(ILogger<HomeController> logger, IStudentRepo repo)
        {
            _logger = logger;
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View(_repo.GetAll());
        }
        public IActionResult GetStudentById(int id)
        {
            Student student = _repo.GetById(id);
            return View(student);
        }
        public IActionResult Privacy([FromServices] IStudentRepo studentRepo)
        
        {
            studentRepo.GetAll();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
