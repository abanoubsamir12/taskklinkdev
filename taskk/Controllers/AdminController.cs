using Microsoft.AspNetCore.Mvc;
using taskk.Data;
using taskk.Models;
namespace taskk.Controllers
{
	public class AdminController : Controller
	{
		private readonly ApplicationDbContext _dp;
		public AdminController(ApplicationDbContext dp)
		{
			_dp = dp;
		}

		public IActionResult Index()
		{
			type model = new type();
			return View(model);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Index(type model)
		{
			try
			{
				int t = model.Id;
				TempData["typeid"] = t;
				if (t == 1)
				{
					return RedirectToAction("IndexTv");
				}
				else if (t == 2)
				{
					return RedirectToAction("Indexlap");
				}
				else if (t == 3)
				{
					return RedirectToAction("IndexSS");
				}
				else
					return View(t);
			}
			catch(Exception )
            {
				return View(model);
            }
		}
		public IActionResult IndexTv()
		{

			IEnumerable<TV> d = _dp.tvs;
			return View(d);
		}
		public IActionResult deleteTv(int? id)
		{
			var obj = _dp.tvs.Find(id);
			if (obj == null)
				return RedirectToAction("Index");
			_dp.tvs.Remove(obj);
			_dp.SaveChanges();
			return RedirectToAction("IndexTv");
		}
		public IActionResult editTv(int? id)
		{
			if (id == null)
				return NotFound();
			var obj = _dp.tvs.Find(id);
			if (obj == null)
				return NotFound();

			return View(obj);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult editTv(TV obj)
		{
			if (obj == null)
				return View(obj);
			_dp.tvs.Update(obj);
			_dp.SaveChanges();
			return RedirectToAction("IndexTv");
		}
		public IActionResult createTv()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult createTv(TV model)
		{

			if (!ModelState.IsValid)
			{
				return createTv(model);
			}
			_dp.tvs.Add(model);
			_dp.SaveChanges();
			return RedirectToAction("IndexTv");
		}
		public IActionResult Indexlap()
		{
			IEnumerable<Laptop> d = _dp.laptops;

			return View(d);
		}
		public IActionResult createlap()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult createlap(Laptop model)
		{

			if (!ModelState.IsValid)
			{
				return createlap(model);
			}
			_dp.laptops.Add(model);
			_dp.SaveChanges();
			return RedirectToAction("Indexlap");
		}
		public IActionResult deletelap(Laptop obj)
		{
			if (obj == null)
				return View(obj);
			_dp.laptops.Remove(obj);
			_dp.SaveChanges();
			return RedirectToAction("Indexlap");
		}


		public IActionResult editlap(int? id)
		{
			if (id == null)
				return NotFound();
			var obj = _dp.laptops.Find(id);
			if (obj == null)
				return NotFound();

			return View(obj);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult editlap(Laptop obj)
		{
			if (obj == null)
				return View(obj);
			_dp.laptops.Update(obj);
			_dp.SaveChanges();
			return RedirectToAction("Indexlap");
		}


		

		public IActionResult IndexSS()
		{
			IEnumerable<SoundSystem> d = _dp.ssystems;

			return View(d);
		}
		public IActionResult createSS()
		{
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult createSS(SoundSystem model)
		{

			if (!ModelState.IsValid)
			{
				return createSS(model);
			}
			_dp.ssystems.Add(model);
			_dp.SaveChanges();
			return RedirectToAction("IndexSS");
		}
		public IActionResult deleteSS(SoundSystem obj)
		{
			if (obj == null)
				return View(obj);
			_dp.ssystems.Remove(obj);
			_dp.SaveChanges();
			return RedirectToAction("IndexSS");
		}


		public IActionResult editSS(int? id)
		{
			if (id == null)
				return NotFound();
			var obj = _dp.ssystems.Find(id);
			if (obj == null)
				return NotFound();

			return View(obj);
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult editSS(SoundSystem obj)
		{
			if (obj == null)
				return View(obj);
			_dp.ssystems.Update(obj);
			_dp.SaveChanges();
			return RedirectToAction("IndexSS");
		}
	}
}



