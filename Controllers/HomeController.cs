using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Szerveroldali_gyak02.Models;

namespace Szerveroldali_gyak02.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greetings = hour < 12 ? "Good Morning" : "Good Afternoon"; // Beepített Dictionary, Greetings kulcsszo most jon letre
            return View("MyView");
        }

        [HttpGet]
        public ViewResult InviteForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult InviteForm(GuestResponse response)
        {
            // itt kell adatot menteni
            Repository.AddResponse(response);
            return View("Thanks", response);
        }

        [HttpGet]
        public ViewResult ListResponses() 
        {
            return View(
                    Repository.Response.Where(r => r.WillAttend == true)
                );
        }
    }
}
