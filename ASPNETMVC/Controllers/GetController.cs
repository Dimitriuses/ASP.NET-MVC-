using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNETMVC.Controllers
{
    public class GetController : Controller
    {
        // GET: Get
        public ActionResult Index()
        {
            return View();
        }
    }
}