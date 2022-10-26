using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Database;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class UsersController : Controller
    {
        private readonly ILogger<UsersController> _logger;
        private readonly AppDbContext _dbContext;

        public UsersController(ILogger<UsersController> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var data = _dbContext.Users.ToList();
            return View(data);
        }

        public IActionResult New()
        {
            return View();
        }
        [HttpPost]
        public IActionResult New(User user)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Add(user);
                _dbContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Detail(int? id)
        {
            return View(_dbContext.Users.Find(id));
        }
    }
}
