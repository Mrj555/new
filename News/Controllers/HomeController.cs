using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace News.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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

        public ActionResult Meng()
        {

            return View();
        }
        public ActionResult List()
        {

           
            string[] data = new string[]
                {"轻薄高分屏固态盘ThinkPadnew S2售5499",
                "苹果The new iPad 64GB/Cellular和苹果iPad Air 64GB/Cellular",
                "“新金融科技2016”会议12月上海将启"
                };
           
            ViewBag.Data = data;
            return View();
        }

    }
}