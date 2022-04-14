using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMvc.Models.EntityFramework;
namespace OgrenciNotMvc.Controllers
{
    public class KuluplerController : Controller
    {
        // GET: Kulupler
        DbMvcOkulEntities db=new DbMvcOkulEntities();
        public ActionResult Index()
        {
            var kulupler=db.TBLKULUPLER.ToList();
            return View(kulupler);
        }
        [HttpGet]
        public ActionResult YeniKulup()
        {
            return View();
        }
        [HttpPost]
        public ActionResult YeniKulup(TBLKULUPLER p)
        {
            db.TBLKULUPLER.Add(p);
            db.SaveChanges();
            return View();
        }
    }
}