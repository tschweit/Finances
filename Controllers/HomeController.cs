namespace Finances.Controllers
{
	using System.Web.Mvc;

	using Models;

	public class HomeController : Controller
	{
		/*public ActionResult Index()
		{
			return View(new Expense()
			{
			});
		}*/

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}