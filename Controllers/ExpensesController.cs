namespace Finances.Controllers
{
	using System.Linq;
	using System.Web.Mvc;
	using Models;
	using MongoDB.Driver.Linq;

	public class ExpensesController : BaseController
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Add()
		{
			var expense = new Expense();
			return View("Edit", expense);
		}

		public ActionResult Edit(ExpenseView view)
		{
			var database = GetDatabase();
			var allExpenses = database.GetCollection<Expense>("Expense").AsQueryable();
			var expense = allExpenses.FirstOrDefault(x => x.Id == view.Id) ?? (Expense)view;
			return View(expense);
		}
	}
}