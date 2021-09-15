using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Website_GiuaKi_Nhom4.Models;

namespace Website_GiuaKi_Nhom4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            

            return View();
        }

        public ActionResult Contact()
        {
           

            return View();
        }
        public ActionResult login (Khachhang model)
        {


            return View();
        }
        public ActionResult cart()
        {


            return View();
        }
        public ActionResult blog()
        {


            return View();
        }
        public ActionResult blogdetails()
        {


            return View();
        }
        public ActionResult productdetails()
        {


            return View();
        }
        public ActionResult shop_category()
        {


            return View();
        }
    }
}