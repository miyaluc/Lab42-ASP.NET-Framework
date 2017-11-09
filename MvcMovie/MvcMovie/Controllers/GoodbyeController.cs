using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class GoodbyeController : Controller
    {
        // GET: /Goodbye/
        public ActionResult Index()
        {
            return View();
            //return "Here is my default action.";
        }

        // GET: /Goodbye/Aloha/ 

        public ActionResult Aloha(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;

            return View();
            //return "Aloha means hello and goodbye....";
            //passing parameter information from the URL to the controller
            //return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}