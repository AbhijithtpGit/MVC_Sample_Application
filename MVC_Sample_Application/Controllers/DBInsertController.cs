using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Sample_Application.Models;

namespace MVC_Sample_Application.Controllers
{
    public class DBInsertController : Controller
    {
        MVC_Sample_ApplicationEntities dbobj = new MVC_Sample_ApplicationEntities();
        // GET: DBInsert
        public ActionResult pageload()
        {
            return View();
        }
        public ActionResult ButtonClick(Insert clsobj)
        {
            if (ModelState.IsValid)
            {
                dbobj.sp_insert(clsobj.Name, clsobj.Age, clsobj.Email);
                clsobj.Message = "insert succfully";
                return View("pageload", clsobj);
            }
            return View("pageload", clsobj);
        }

    }
}