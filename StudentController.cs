using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PracticleDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ViewResult Personal()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Personal(string sname,string contact,string address)
        {
            if(sname == "" || contact=="" || address=="")
            {
                ViewBag.msg = "Invalid";
                return View();
            }
            else
            {
                TempData["sname"]=sname;
                TempData["address"]=address;
                TempData["contact"] = contact;
                return RedirectToAction("marks");
            }
        }
        public ActionResult Marks()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Marks(int tmarks=0,int pmarks=0 , int omarks=0)
        {
            if(tmarks<0||tmarks>100||pmarks<0||pmarks>50||omarks<0||omarks>50)
            {
                ViewData["msg"]=("Invalid Marks");
                return View();
            }
            else
            {
                TempData["Theory"]=tmarks;
                TempData["Practicle"] = pmarks;
                TempData["Oral"] = omarks;
                return RedirectToAction("Marksheet");
            }
                
        }
        public ActionResult Marksheet()
        {
            return View();
        }
       
    }
}