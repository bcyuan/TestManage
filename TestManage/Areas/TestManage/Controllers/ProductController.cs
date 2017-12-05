using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestManage.Areas.TestManage.Controllers
{
    public class ProductController : Controller
    {
        // GET: TestManage/Product
        public ActionResult Index()
        {
            return View();
        }
    }
}