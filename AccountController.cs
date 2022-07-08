
//Hi Akshay, Savin here.
//hii akshya bhau rajat here

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//Comment Added
namespace PracticleDemo.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ViewResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection values)
        {
            if (values["uname"] == "admin" && values["pass"] == "1234")
            {
                Session["uname"] = "admin";
                return RedirectToAction("Personal","Student");
            }
            else
            {
                ViewBag.msg = "invalid";
                return View();
            }    
        }
    }
}
