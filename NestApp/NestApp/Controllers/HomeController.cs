using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NestApp.DAL;

namespace NestApp.Controllers
{
	public class HomeController : Controller
	{
		private readonly AppDbContext _context;

		public HomeController(AppDbContext context)
		{
			_context=context;
		}

		public async Task<IActionResult> Index()
		{
			var sliders= await _context.Sliders.ToListAsync();
			return View(sliders);
		}
	}
}
