using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services;
//using seekPV.Models;
using libref.Models;

namespace libref.Controllers
{
    //this  controler  retrives the value of each  input tag
    public class IndexController : Controller
    {
        public ActionResult seek()
            //seekhtml
        {
            return View(new Models.seekPV() { partialModel= seek() });
        }
        
        /* // GET: hello
         public ActionResult Index()
         {
             return View();
         }

         // GET: hello/Details/5
         public ActionResult Details(int id)
         {
             return View();
         }

         // GET: hello/Create
         public ActionResult Create()
         {
             return View();
         }

         // POST: hello/Create
         [HttpPost]
         public ActionResult Create(FormCollection collection)
         {
             try
             {
                 // TODO: Add insert logic here

                 return RedirectToAction("Index");
             }
             catch
             {
                 return View();
             }
         }

         // GET: hello/Edit/5
         public ActionResult Edit(int id)
         {
             return View();
         }

         // POST: hello/Edit/5
         [HttpPost]
         public ActionResult Edit(int id, FormCollection collection)
         {
             try
             {
                 // TODO: Add update logic here

                 return RedirectToAction("Index");
             }
             catch
             {
                 return View();
             }
         }

         // GET: hello/Delete/5
         public ActionResult Delete(int id)
         {
             return View();
         }

         // POST: hello/Delete/5
         [HttpPost]
         public ActionResult Delete(int id, FormCollection collection)
         {
             try
             {
                 // TODO: Add delete logic here

                 return RedirectToAction("Index");
             }
             catch
             {
                 return View();
             }
         }
         */
    }
}
