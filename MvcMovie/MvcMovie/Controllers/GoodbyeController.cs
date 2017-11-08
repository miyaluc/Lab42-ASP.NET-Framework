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
        public string Index()
        {
            return "Here is my default action.";
        }

        // GET: /Goodbye/Aloha/ 

        public string Aloha()
        {
            return "Aloha means hello and goodbye....";
        }
    }
}