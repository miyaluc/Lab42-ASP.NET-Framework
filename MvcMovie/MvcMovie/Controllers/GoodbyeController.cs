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

        public string Aloha(string name, int ID = 1)
        {
            //return "Aloha means hello and goodbye....";
            //passing parameter information from the URL to the controller
            return HttpUtility.HtmlEncode("Hello " + name + ", ID: " + ID);
        }
    }
}