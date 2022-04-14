using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMvc.Models.EntityFramework;
namespace OgrenciNotMvc.Controllers
{
    public class NotlarController : Controller
    {
        DbMvcOkulEntities db=new DbMvcOkulEntities();
        // GET: Notlar
        public ActionResult Index()
        {
            var notlar=db.TBLNOTLAR.ToList();
            return View(notlar);
        }
    }
}