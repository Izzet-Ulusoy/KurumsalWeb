using KurumsalWeb.Models.DataContext;
using KurumsalWeb.Models.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace KurumsalWeb.Controllers
{
    public class KimlikController : Controller
    {
        KurumsalDBContext _db = new KurumsalDBContext();
        // GET: Kimlik
        public ActionResult Index()
        {
            return View(_db.Kimlik.ToList());
        }

        // GET: Kimlik/Edit/5
        public ActionResult Edit(int id)
        {
            var kimlik = _db.Kimlik.Where(x => x.KimlikId == id).SingleOrDefault();
            return View(kimlik);
        }

        // POST: Kimlik/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Kimlik kimlik, HttpPostedFileBase LogoURL)
        {
            if (ModelState.IsValid)
            {
                var kk = _db.Kimlik.Where(x => x.KimlikId == kimlik.KimlikId).SingleOrDefault();
                if (LogoURL != null)
                {
                    if (System.IO.File.Exists(Server.MapPath(kk.LogoURL)))//Daha önce bir resim varsa silmek için yazdık
                    {
                        System.IO.File.Delete(Server.MapPath(kk.LogoURL));
                    }
                    WebImage img = new WebImage(LogoURL.InputStream);
                    FileInfo imginfo = new FileInfo(LogoURL.FileName);
                    string logoName = LogoURL.FileName + imginfo.Extension;
                    img.Resize(300, 300);
                    img.Save("~/Uploads/Kimlik/" + logoName);
                    kk.LogoURL = "/Uploads/Kimlik/" + logoName;
                }
                kk.Title = kimlik.Title;
                kk.Unvan = kimlik.Unvan;
                kk.Keywords = kimlik.Keywords;
                kk.Description = kimlik.Description;
                kk.AktifMi = kimlik.AktifMi;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kimlik);
        }

    }
}
