using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Deeproxio.SettingsApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace Deeproxio.SettingsApi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

	    public async Task<StringContent> SampleLogin()
	    {
		    var client = new HttpClient();

		    var stringTask = await client.GetAsync("http://aiconception.accountsvc/Account/Login");

		    return new StringContent(stringTask.ToString());
	    }
	}
}
