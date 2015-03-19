namespace Finances.Controllers
{
	using System.Linq;
	using System.Web.Mvc;
	using Models;
	using MongoDB.Bson;
	using MongoDB.Driver.Linq;

	public class ExpensesController : BaseController
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Add()
		{
			return View("Edit", new Expense());
		}

		public ActionResult Edit(ObjectId id)
		{
			var database = GetDatabase();
			var allExpenses = database.GetCollection<Expense>("Expense").AsQueryable();
			var expense = allExpenses.Where(x => x.Id == id);
			return View(expense);
		}
	}
}