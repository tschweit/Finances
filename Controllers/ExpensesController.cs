namespace Finances.Controllers
{
	using System.Web.Mvc;
	using Models;

	public class ExpensesController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Edit()
		{
			return View(new Expense());
		}
	}
}