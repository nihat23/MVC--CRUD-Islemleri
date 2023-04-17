using MVC__CRUD_Islemleri.Models;// kutuphanemz
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC__CRUD_Islemleri.Controllers
{
    public class HomeController : Controller
    {

        UrunLerDbConTexT urunLerDbConTexT = new UrunLerDbConTexT();

        // GET: Home
        public ActionResult Index(string kelime)
        {

            ViewBag.Kelime = kelime;
            if (!string.IsNullOrEmpty(kelime))
            {
                return View(urunLerDbConTexT.Urunler.Where(u => u.UrunAd.Contains(kelime)).ToList());
            }

            return View(urunLerDbConTexT.Urunler.ToList());
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(Urunler urun)
        {
            try
            {
                // TODO: Add insert logic here
                urunLerDbConTexT.Urunler.Add(urun);
                urunLerDbConTexT.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(urun);
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            return View(urunLerDbConTexT.Urunler.Find(id));
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Urunler urun)
        {
            try
            {
                // TODO: Add update logic here
                urunLerDbConTexT.Entry(urun).State = System.Data.Entity.EntityState.Modified;
                urunLerDbConTexT.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(urun);
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View(urunLerDbConTexT.Urunler.Find(id));
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                var silinecekUrun = urunLerDbConTexT.Urunler.Find(id);
                urunLerDbConTexT.Urunler.Remove(silinecekUrun);
                urunLerDbConTexT.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
