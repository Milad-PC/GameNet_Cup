using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BijBijCup.Controllers
{
    public class HomeController : Controller
    {
        private MyContext db = new MyContext();
        DateTime PlayDate = new DateTime(2022, 3, 15);
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Time = $"{((PlayDate - DateTime.Now).TotalDays).ToString("00")}:" +
                $"{((int)(PlayDate - DateTime.Now).TotalHours % 24).ToString("00")}";
            int x;
            try
            {
                x = db.GameNets.Sum(u => u.Capacity);
            }
            catch (Exception)
            {
                x = 0;
            }


            ViewBag.Cap = $"{x - db.Users.Count()}/{x}";
            return View();
        }
        public ActionResult Register()
        {
            ViewBag.GameNet = GetGameNet();
            return View();
        }
        [HttpPost]
        public ActionResult Register(Models.RegisterUsers input)
        {
            if (input.FullName == null)
            {
                ModelState.AddModelError("FullName", "نام وارد نشده است");
                ViewBag.GameNet = GetGameNet();
                return View(input);
            }
            else if (input.CodeMeli == null)
            {
                ModelState.AddModelError("CodeMeli", "کد ملی وارد نشده است");
                ViewBag.GameNet = GetGameNet();
                return View(input);
            }
            else if (input.Phone == null)
            {
                ModelState.AddModelError("Phone", "شماره همراه وارد نشده است");
                ViewBag.GameNet = GetGameNet();
                return View(input);
            }
            else if (!input.Phone.StartsWith("09"))
            {
                ModelState.AddModelError("Phone", "شماره همراه باید با 09 شروع شود");
                ViewBag.GameNet = GetGameNet();
                return View(input);
            }
            else if (input.Phone.Count() != 11)
            {
                ModelState.AddModelError("Phone", "شماره همراه باید 11 رقمی باشد");
                ViewBag.GameNet = GetGameNet();
                return View(input);
            }
            else if (input.CodeMeli.Count() != 10)
            {
                ModelState.AddModelError("CodeMeli", "کد ملی باید 10 رقمی باشد");
                ViewBag.GameNet = GetGameNet();
                return View(input);
            }
            else if (db.Users.Any(u => u.CodeMeli == input.CodeMeli))
            {
                ModelState.AddModelError("CodeMeli", "کد ملی وارد شده تکراری است شما قبلا ثبت نام کردید");
                ViewBag.GameNet = GetGameNet();
                return View(input);
            }
            else if (db.Users.Any(u => u.Phone == input.Phone))
            {
                ModelState.AddModelError("Phone", "با این شماره همراه یکبار ثبت نام انجام شده");
                ViewBag.GameNet = GetGameNet();
                return View(input);
            }
            else if (input.GameNetID == 0)
            {
                ModelState.AddModelError("GameNetID", "لطفا یک گیم نت را انتخاب کنید");
                ViewBag.GameNet = GetGameNet();
                return View(input);
            }
            try
            {
                input.RegDate = DateTime.Now;
                db.Users.Add(input);
                db.SaveChanges();
                return RedirectToAction("Verify", input);
            }
            catch
            {
                ModelState.AddModelError("Phone", "خطایی رخ داده است لطفا دوباره امتحان کنید");
                ViewBag.GameNet = GetGameNet();
                return View(input);
            }
        }
        public ActionResult Verify(Models.RegisterUsers input)
        {
            Models.GameNet g = db.GameNets.Find(input.GameNetID);
            ViewBag.GameNet = g;
            try
            {
                //SMS
                string text = $"کاربر گرامی جناب {input.FullName} ثبت نام" +
                                $" شما با موفقیت انجام شد در گیم نت {g.GameNetName} منتظر شما هستیم\nآدرس" +
                                $" : {g.Address}\n لینک نصب اپلیکیشن : https://bijbij.ir/";
                SmsServer.smsserverPortType client = new SmsServer.smsserverPortTypeClient();
                SmsServer.sendPatternSmsRequest sprq = new SmsServer.sendPatternSmsRequest();
                sprq.user = "ap-9113200056";
                sprq.pass = "9113200056";
                sprq.toNum = new string[] { input.Phone };
                sprq.fromNum = "3000505";
                sprq.pattern_code = "34dktenteo";


                var data = new SmsServer.input_data_type[] {
                    // key is your parameter name and value is what you want to send to the receiptor 
                    new SmsServer.input_data_type(){ key ="name",value = input.FullName } ,
                    new SmsServer.input_data_type(){ key ="gamenet",value = g.GameNetName },
                     new SmsServer.input_data_type(){ key ="address",value = g.Address }
                };
                sprq.input_data = data;

                string result = client.sendPatternSms(sprq).@return;
                //End SMS
                Models.SMSHis s = new Models.SMSHis()
                {
                    Phone = input.Phone,
                    Result = result,
                    SendDate = DateTime.Now,
                    Text = text
                };
                db.SMS.Add(s);
                db.SaveChanges();
            }
            catch { }
            return View(input);
        }
        public ActionResult Help()
        {
            return View(db.GameNets);
        }
        public IEnumerable<Models.GameNetModelView> GetGameNet()
        {
            List<Models.GameNet> src = db.GameNets.ToList();
            List<Models.GameNetModelView> output = new List<Models.GameNetModelView>();
            foreach (var x in src)
            {
                int c = db.Users.Count(u => u.GameNetID == x.GameNetID);
                if (c < x.Capacity)
                {
                    output.Add(new Models.GameNetModelView()
                    {
                        GameNetID = x.GameNetID,
                        GameNetName = x.GameNetName,
                        Capacity = x.Capacity - c
                    });
                }
            }
            return output;
        }
    }
}