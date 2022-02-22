using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BijBijCup.Areas.Admin.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private MyContext db = new MyContext();

        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Dashboard()
        {
            return View(db.Users);
        }
        public ActionResult UsersList()
        {
            return View(db.Users);
        }
        public PartialViewResult LastRegister()
        {
            return PartialView(db.Users);
        }
        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult SignIn(string UserName, string Password, bool Remember = true)
        {
            if (UserName == "Mobin" && Password == "Mobin@Light")
            {
                FormsAuthentication.SetAuthCookie(UserName, Remember);
                return RedirectToAction("Dashboard");
            }
            return RedirectToAction("Index");
        }
    }
}