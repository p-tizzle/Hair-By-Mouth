using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using hairByMouth2.Models;

namespace hairByMouth2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        [HttpPost]
        public ActionResult HairEntry(EntryModel entrymodel)
        {

            return View("HairForm");
        }
    }
    }
