using Microsoft.AspNetCore.Mvc;
using taskk.Data;

namespace taskk.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext db;
        public ShopController(ApplicationDbContext dp)
        {
            this.db = dp;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
