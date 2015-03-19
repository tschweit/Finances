namespace Finances.Controllers
{
	using System.Web.Mvc;
	using MongoDB.Driver;

	public class BaseController : Controller
	{
		public MongoDatabase GetDatabase()
		{
			var client = new MongoClient();
			var server = client.GetServer();
			var database = server.GetDatabase("FinancialPlanning");
			return database;
		}
	}
}