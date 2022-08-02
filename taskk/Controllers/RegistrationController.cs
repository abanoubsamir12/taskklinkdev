using Microsoft.AspNetCore.Mvc;
using taskk.Data;
using taskk.Models;

namespace taskk.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly ApplicationDbContext db;
        public RegistrationController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(UserInfo obj)
        {
            if (ModelState.IsValid)
            {

                var obj1 = db.users.FirstOrDefault(u => u.Username.Equals(obj.Username));
                if (obj1 != null)
                {
                    ModelState.AddModelError("already used username", "The user name you choosed is already taken , please write another one");
                    TempData["err"] = "The username you choosed is already taken , please write another one";
                    return View(obj);
                }
                var obj2 = db.users.FirstOrDefault(u => u.Email.Equals(obj.Email));
                if (obj2 != null)
                {
                    ModelState.AddModelError("already used email", "The email you entered is already taken , please write another one");
                    TempData["errEmail"] = "The email you entered is already taken , please write another one";
                    return View(obj);
                }
                TempData["err"] = null;            
                db.users.Add(obj);
                db.SaveChanges();
                TempData["Success"] = "User " + obj.Username + " is Created Successfully ! \n Go , login and enjoooy ";
                return RedirectToAction("Index");
            
            }
            return View(obj);
        }
        public IActionResult Login()
        {
            return View(new LoginModel());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginModel model)
        {
            
            if (!ModelState.IsValid)
                return View(model);

            var obj =  db.users.SingleOrDefault(n => n.Username.Equals(model.Username ) && n.Pwd.Equals(model.Pwd));
            if (obj == null)
                return View(model);
            TempData["name"] = model.Username;
            TempData["Success"] = "User Login Succefully";
             return RedirectToAction("Index");
            
        }

        public IActionResult adminLogin()
		{
            return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
        public IActionResult adminLogin(Admin a)
		{
            if (!ModelState.IsValid)
                return View(a);
            var obj = db.admins.SingleOrDefault(n => n.Name.Equals(a.Name) && n.password.Equals(a.password));
            if (obj == null)
                return View(a);
            return RedirectToAction("Index" , "Admin");
		}
    }
}