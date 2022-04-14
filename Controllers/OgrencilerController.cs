using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OgrenciNotMvc.Models.EntityFramework;
namespace OgrenciNotMvc.Controllers
{
    public class OgrencilerController : Controller
    {

        // GET: Ogrenciler
        DbMvcOkulEntities db=new DbMvcOkulEntities();
        public ActionResult Index()
        {
            var ogrenciler=db.TBLOGRENCILER.ToList();
            return View(ogrenciler);
        }
        [HttpGet]
        public ActionResult YeniOgrenci()
        {
            List<SelectListItem> degerler=(from i in db.TBLKULUPLER.ToList()
                                           select new SelectListItem
                                           {
                                               Text=i.KULUPAD,
                                               Value=i.KULUPID.ToString()

                                           }).ToList();

            ViewBag.dgr = degerler;                     
            return View();
        }
        [HttpPost]
        public ActionResult YeniOgrenci(TBLOGRENCILER p3)
        { 
            var klp=db.TBLKULUPLER.Where(m=>m.KULUPID==p3.TBLKULUPLER.KULUPID).FirstOrDefault();
            p3.TBLKULUPLER = klp;
           
            db.TBLOGRENCILER.Add(p3);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}