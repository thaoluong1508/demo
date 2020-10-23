using QLNS.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLNS.Controllers
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
            MyModel obj = new MyModel();
            obj.hoten = "Luong Thi Thao";
            obj.tuoi = "21";
            ViewBag.WelcomeString = "Welcome to the wild";
            return View(obj);
        }
    }
}