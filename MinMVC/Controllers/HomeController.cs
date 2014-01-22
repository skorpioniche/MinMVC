using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using MinMVC.Controllers;
using MinMVC.ViewModel;


namespace MinMVC
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var model = new HomeViewModel()
                {
                    Accept = SingThread.Instance.sharesaccepted.ToString(),
                    Proc = Environment.ProcessorCount.ToString(),
                    Speed = SingThread.Instance.hashspeed.ToString(),
                    Submit = SingThread.Instance.shresubmitted.ToString()
                };

            return View(model);
        }

        public ActionResult Start()
        {
            SingThread.Instance.go(Values.Url, Values.User, Values.Pass);
            return View();
        }

        public ActionResult Stop()
        {
            SingThread.Instance.Started = false;
            return View();
        }
    }
}
