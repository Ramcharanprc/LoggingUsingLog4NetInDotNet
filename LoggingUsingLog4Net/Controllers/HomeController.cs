using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoggingUsingLog4Net.Controllers
{
    public class HomeController : Controller
    {
        ILog log = log4net.LogManager.GetLogger(typeof(HomeController));

        public ActionResult Index()
        {
            try
            {
                int[] k = { 0 ,1,2,3};
                log.Debug(k);
                //Console.WriteLine(k[10]);
                throw new Exception("Custom log levels can also be defined in configuration. " +
                    "This is convenient for using a custom level in a logger filter or an appender " +
                    "filter. Similar to defining log levels in code, a custom level must be defined " +
                    "first, before it can be used. If a logger or appender is configured with an " +
                    "undefined level, that logger or appender will be invalid and will not process " +
                    "any log events.The CustomLevel configuration element creates a custom level." +
                    "Internally it calls the same Level.forName() method discussed above.");
            }
            catch(Exception ex)
            {
                log.Error(ex);

                log.Info(ex);

                log.Warn(ex);
                log.Fatal(ex);

            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}