namespace Finances.Controllers
{
	using System;
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
			var expense = new ExpenseView(){Date = DateTime.Today.ToShortDateString()};
			return View("Edit", expense);
		}

		public ActionResult Edit(ObjectId id)
		{
			var database = GetDatabase();
			var allExpenses = database.GetCollection<Expense>("Expense").AsQueryable();
			var expense = allExpenses.FirstOrDefault(x => x.Id == id);
			return View("Edit", new ExpenseView(expense));
		}

		[HttpPost]
		public ActionResult Save(ExpenseView view)
		{
			var database = GetDatabase();
			var expense = (Expense)view;
			database.GetCollection<Expense>("Expense").Save(expense);
			return View("Index");
		}

		// ?? (Expense)view;
	}
}