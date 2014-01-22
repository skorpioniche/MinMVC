using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using MinMVC.Controllers;


namespace MinMVC
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public string Index()
        {

            return SingThread.Instance.hashspeed.ToString();
        }

        public ActionResult Start()
        {
            SingThread.Instance.go("http://pool-nvc.khore.org:8080", "skoprioniche.1", "x");
            return View();
        }

        public ActionResult Stop()
        {

            return View();
        }
    }
}
