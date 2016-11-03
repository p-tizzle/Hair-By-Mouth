using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using hairByMouth2.Data;
using hairByMouth2.Models;

namespace hairByMouth2.Controllers
{
    public class HomeController : Controller
    {
        private HairContext db = new HairContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View(db.EntryModels.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntryModel entryModel = db.EntryModels.Find(id);
            if (entryModel == null)
            {
                return HttpNotFound();
            }
            return View(entryModel);
        }





        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult HairForm()
        {
            ViewBag.Message = "my form";
            var model = new HairFormModel
            {
                searchModel = new SearchModel(),
                entryModel = new EntryModel()
            };

            return View("HairForm",model);

        }

        [HttpPost]
        public ActionResult Search(SearchModel searchModel)
        {

            return View("Hairform");
        }

       
        public ActionResult HairEntry()
        {

            return View();
        }
        // GET: EntryModels/Create


        // POST: EntryModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult HairEntry([Bind(Include = "ID,yourName,salonName,stylistName")] EntryModel entryModel)
        {
            if (ModelState.IsValid)
            {
                db.EntryModels.Add(entryModel);
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View(entryModel);
        }

    

    // GET: EntryModels/Edit/5
    public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntryModel entryModel = db.EntryModels.Find(id);
            if (entryModel == null)
            {
                return HttpNotFound();
            }
            return View(entryModel);
        }

        // POST: EntryModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,yourName,salonName,stylistName")] EntryModel entryModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(entryModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("List");
            }
            return View(entryModel);
        }

        // GET: EntryModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EntryModel entryModel = db.EntryModels.Find(id);
            if (entryModel == null)
            {
                return HttpNotFound();
            }
            return View(entryModel);
        }

        // POST: EntryModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EntryModel entryModel = db.EntryModels.Find(id);
            db.EntryModels.Remove(entryModel);
            db.SaveChanges();
            return RedirectToAction("List");
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


        
