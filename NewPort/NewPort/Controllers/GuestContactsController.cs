using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NewPort.Models;

namespace NewPort.Controllers
{
    public class GuestContactsController : Controller
    {
        private GuestDBContext db = new GuestDBContext();

        // GET: GuestContacts
        public ActionResult Index()
        {
            return View(db.Guests.ToList());
        }

        // GET: GuestContacts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GuestContact guestContact = db.Guests.Find(id);
            if (guestContact == null)
            {
                return HttpNotFound();
            }
            return View(guestContact);
        }

        // GET: GuestContacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GuestContacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Email,FirstName,LastName")] GuestContact guestContact)
        {
            if (ModelState.IsValid)
            {
                db.Guests.Add(guestContact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(guestContact);
        }

        // GET: GuestContacts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GuestContact guestContact = db.Guests.Find(id);
            if (guestContact == null)
            {
                return HttpNotFound();
            }
            return View(guestContact);
        }

        // POST: GuestContacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Email,FirstName,LastName")] GuestContact guestContact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(guestContact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(guestContact);
        }

        // GET: GuestContacts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GuestContact guestContact = db.Guests.Find(id);
            if (guestContact == null)
            {
                return HttpNotFound();
            }
            return View(guestContact);
        }

        // POST: GuestContacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            GuestContact guestContact = db.Guests.Find(id);
            db.Guests.Remove(guestContact);
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
