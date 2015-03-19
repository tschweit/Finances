﻿namespace Finances.Models
{
	using System;
	using MongoDB.Bson;

	public class Income
	{
		public ObjectId Id { get; set; }
		public DateTime Date { get; set; }
		public string Description { get; set; }
		public decimal Amount { get; set; }
		public IncomeType IncomeType { get; set; }
	}
}