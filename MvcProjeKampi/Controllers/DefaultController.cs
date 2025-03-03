using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        HeadingManager hm=new HeadingManager(new EfHeadingDal());
        ContentManager cm=new ContentManager(new EfContentDal());
       public ActionResult Headings()
        {
            var headinglist = hm.GetList();
            return View(headinglist);
        }
        public PartialViewResult Index()
        {
            var contentlist=cm.GetList();
            return PartialView(contentlist);
        }
    }
}