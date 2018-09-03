using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AnipchenkoASPNETFilters.Controllers
{
    public class DashController : Controller
    {
        // GET: Dash
        [MyFilter]
        public ActionResult Index()
        {
            return View();
        }
    }
}