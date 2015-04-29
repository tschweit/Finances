namespace Finances.Models
{
	using System;
	using MongoDB.Bson;

	public class Expense
	{
		public ObjectId Id { get; set; }
		public string Description { get; set; }
		public decimal Amount { get; set; }
		public DateTime Date { get; set; }
		public string ExpenseType { get; set; }

		public Expense()
		{
			Id = new ObjectId();
		}

		public static explicit operator Expense(ExpenseView view)
		{
			return new Expense()
			{
				Id = new ObjectId(view.Id),
				Description = view.Description,
				Amount = Int32.Parse(view.Amount),
				Date = DateTime.Parse(view.Date),
				ExpenseType = view.ExpenseType
			};
		}
	}

	public class ExpenseView
	{
		public bool IsNew { get; set; }
		public string Id { get; set; }
		public string Description { get; set; }
		public string Amount { get; set; }
		public string Date { get; set; }
		public string ExpenseType { get; set; }

		public ExpenseView()
		{
			IsNew = true;
			Id = new ObjectId().ToString();
		}

		public ExpenseView(Expense expense)
		{
			Id = expense.Id.ToString();
			Description = expense.Description;
			Amount = expense.Amount.ToString();
			Date = expense.Date.ToShortDateString();
			ExpenseType = expense.ExpenseType;
		}
	}
}