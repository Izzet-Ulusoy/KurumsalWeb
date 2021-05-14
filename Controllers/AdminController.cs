//using KurumsalWeb.Models;
using KurumsalWeb.Models;
using KurumsalWeb.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KurumsalWeb.Controllers
{
    public class AdminController : Controller
    {
        //KurumsalDBEntities _db = new KurumsalDBEntities();
        //KurumsalDB _db = new KurumsalDB();
        KurumsalDBContext _db = new KurumsalDBContext();
        // GET: Admin
        public ActionResult Index()
        {
            //var sorgu = _db.Kategori.Where(x => x.AktifMi == true).ToList();
            var sorgu = _db.Kategori.ToList();

            return View(sorgu);
        }
    }
}