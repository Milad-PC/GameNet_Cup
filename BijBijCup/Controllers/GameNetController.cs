using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BijBijCup.Controllers
{
    public class GameNetController : Controller
    {
        private MyContext db = new MyContext();
        // GET: GameNet
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string phone)
        {
            if (!db.GameNets.Any(u => u.Phone == phone))
            {
                ViewBag.Error = phone;
                return View("Error");
            }
            else 
            {
                int x = db.GameNets.First(u => u.Phone == phone).GameNetID;
                return RedirectToAction("List",new { id = x });
            }
        }
        public ActionResult List(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            else if (!db.GameNets.Any(u => u.GameNetID == id)) return RedirectToAction("Index");
            else
            {
                int Capacity = db.GameNets.Find(id).Capacity;
                ViewBag.Capacity = Capacity > 15 ? Capacity : 15;
                return View(db.Users.Where(u => u.GameNetID == id).OrderByDescending(u => u.RegDate));
            }
        }
    }
}