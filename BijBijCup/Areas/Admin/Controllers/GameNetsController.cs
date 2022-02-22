using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BijBijCup;
using BijBijCup.Models;

namespace BijBijCup.Areas.Admin.Controllers
{
    public class GameNetsController : Controller
    {
        private MyContext db = new MyContext();

        // GET: Admin/GameNets
        public ActionResult Index()
        {
            return View(db.GameNets);
        }
        // GET: Admin/GameNets/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/GameNets/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "GameNetID,GameNetName,Capacity,Address,Phone")] GameNet gameNet)
        {
            if (ModelState.IsValid)
            {
                db.GameNets.Add(gameNet);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gameNet);
        }

        // GET: Admin/GameNets/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameNet gameNet = db.GameNets.Find(id);
            if (gameNet == null)
            {
                return HttpNotFound();
            }
            return View(gameNet);
        }

        // POST: Admin/GameNets/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "GameNetID,GameNetName,Capacity,Address,Phone")] GameNet gameNet)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gameNet).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gameNet);
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
