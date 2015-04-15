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
		public bool IsNew { get; set; }

		public Expense()
		{
			Id = new ObjectId();
			IsNew = true;
		}

		public static explicit operator Expense(ExpenseView view)
		{
			return new Expense()
			{
				Id = view.Id,
				Description = view.Description,
				Amount = view.Amount,
				Date = view.Date,
				ExpenseType = view.ExpenseType
			};
		}
	}

	public class ExpenseView
	{
		public ObjectId Id { get; set; }
		public string Description { get; set; }
		public decimal Amount { get; set; }
		public DateTime Date { get; set; }
		public string ExpenseType { get; set; }

		public ExpenseView(Expense expense)
		{
			Id = expense.Id;
			Description = expense.Description;
			Amount = expense.Amount;
			Date = expense.Date;
			ExpenseType = expense.ExpenseType;
		}
	}
}