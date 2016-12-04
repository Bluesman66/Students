using Students.Models;
using System.Linq;
using System.Web.Mvc;

namespace Students.Controllers
{
	public class HomeController : Controller
	{
		private StudentsContext db = new StudentsContext();

		public ActionResult Index()
		{
			return View(db.Students.ToList());
		}

		public ActionResult Details(int id = 0)
		{
			Student student = db.Students.Find(id);
			if (student == null)
			{
				return HttpNotFound();
			}
			return View(student);
		}

		protected override void Dispose(bool disposing)
		{
			db.Dispose();
			base.Dispose(disposing);
		}
	}
}