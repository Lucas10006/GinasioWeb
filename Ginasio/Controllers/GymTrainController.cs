using Ginasio.Models;
using Microsoft.AspNetCore.Mvc;

namespace Ginasio.Controllers
{
    public class GymTrainController : Controller
    {
        private readonly GinDbContext _context;
        private readonly IWebHostEnvironment webHostEnvironment;

        public GymTrainController(GinDbContext dbcontext, IWebHostEnvironment webHostEnvironment)
        {
            this._dbcontext = dbcontext;
            this.webHostEnvironment = webHostEnvironment;  
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
