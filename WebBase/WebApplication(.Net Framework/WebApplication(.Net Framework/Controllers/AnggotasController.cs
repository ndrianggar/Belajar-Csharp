using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication_.Net_Framework.Data;
using WebApplication_.Net_Framework.Models;

namespace WebApplication_.Net_Framework.Controllers
{
    public class AnggotasController : Controller
    {
        private WebApplication_Net_FrameworkContext db = new WebApplication_Net_FrameworkContext();

        // GET: Anggotas
        public ActionResult Index()
        {
            return View(db.Anggotas.ToList());
        }

        // GET: Anggotas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anggota anggota = db.Anggotas.Find(id);
            if (anggota == null)
            {
                return HttpNotFound();
            }
            return View(anggota);
        }

        // GET: Anggotas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Anggotas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AnggotaId,NamaAnggota,Umur,Alamat,NoTelp")] Anggota anggota)
        {
            if (ModelState.IsValid)
            {
                db.Anggotas.Add(anggota);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(anggota);
        }

        // GET: Anggotas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anggota anggota = db.Anggotas.Find(id);
            if (anggota == null)
            {
                return HttpNotFound();
            }
            return View(anggota);
        }

        // POST: Anggotas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AnggotaId,NamaAnggota,Umur,Alamat,NoTelp")] Anggota anggota)
        {
            if (ModelState.IsValid)
            {
                db.Entry(anggota).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(anggota);
        }

        // GET: Anggotas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Anggota anggota = db.Anggotas.Find(id);
            if (anggota == null)
            {
                return HttpNotFound();
            }
            return View(anggota);
        }

        // POST: Anggotas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Anggota anggota = db.Anggotas.Find(id);
            db.Anggotas.Remove(anggota);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
