using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class DefaultController : Controller
    {
        HeadingManager hm = new HeadingManager(new EfHeadingDal());
        public ActionResult Headings()//ctrl+k+d
        {
            var headinglist = hm.GetList();
            return View(headinglist);
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}//82