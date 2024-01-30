using Homework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Homework.Controllers
{
	public class APIController : Controller
	{
		private readonly MyDBContext _context;

		public APIController(MyDBContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Homework2(string name)
		{
			var check = _context.Members.FirstOrDefault(m => m.Name == name);
			if (check==null)
			{
				return Content("帳號可使用");
			}
			return Content("帳號已存在");
			//return Content($"Hello {check.Name}, {check.Age}歲了, 電子郵件是 {check.Email}", "text/plain", Encoding.UTF8);
		}
	}
}
