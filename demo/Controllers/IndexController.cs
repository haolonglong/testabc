using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Maticsoft.BLL;
namespace demo.Controllers
{
    public class IndexController : Controller
    {
        //
        // GET: /Index/

        master tb_mastet = new master();
        public ActionResult Index()
        {


           // System.Data.DataSet ds = tb_mastet.GetAllList();

           return View();
        }
        public ActionResult register()
        {
            return View();
        }


    }
}
