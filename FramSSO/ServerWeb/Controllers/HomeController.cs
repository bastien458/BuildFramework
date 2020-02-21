using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServerWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "HELLLO";
        }

        public string Index2(int id)
        {
            return "Hello" + id;
        }
    }
}