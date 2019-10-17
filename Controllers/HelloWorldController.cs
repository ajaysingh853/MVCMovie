using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            //return "This is my default action...";
            return View();
        }

        // GET: /HelloWorld/Welcome/ 
        public IActionResult Welcome(string name, int ID = 1)
        {
            //return HtmlEncoder.Default.Encode ($"Hello {name}, ID: {ID}");
            ViewData["Msg"] = "Hello " + name;
            ViewData["Time"] = ID;

            return View();
        }
    }
}