using Microsoft.AspNetCore.Mvc;
using taskk.Data;
using taskk.Models;

namespace taskk.Controllers
{
    public class ClassController : Controller
    {
        private readonly ApplicationDbContext _dp;
        public ClassController(ApplicationDbContext dp)
        {
            _dp = dp;
        }

        public IActionResult Index()
        {
            IEnumerable<Class> d = _dp.classes;   
            return View(d);
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Class obj)
        {
            if (obj.Name == "ss")
            {
                ModelState.AddModelError("name", "ss is not valid");

            }
            if (ModelState.IsValid)
            {

                _dp.classes.Add(obj);
                _dp.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();
            var obj = _dp.classes.Find(id);
            if (obj == null)
                return NotFound();

            return View(obj);
        }
        public IActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();
            var obj = _dp.classes.Find(id);
            if (obj == null)
                return NotFound();
            _dp.classes.Remove(obj);
            _dp.SaveChanges();
            return RedirectToAction("Index");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Class obj)
        {
            if (obj.Name == "ss")
            {
                ModelState.AddModelError("name", "ss is not valid");

            }
            if (ModelState.IsValid)
            {

                _dp.classes.Update(obj);
                _dp.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
    }
}
