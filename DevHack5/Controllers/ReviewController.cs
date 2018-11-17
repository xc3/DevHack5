using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DevHack5.Models;
using DevHack5.Context;

namespace DevHack5.Controllers
{
    public class ReviewController : Controller
    {
        private DevHacksContext db = new DevHacksContext();
        // GET
        public ActionResult CreateReview()
        {
            return View();
        }

        // POST
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult CreateReview([Bind(Include="Id,Description,Stars,Date")] Review review)
        {
            if(ModelState.IsValid)
            {
                db.Reviews.Add(review);
                db.SaveChanges();
                return RedirectToAction("Reviews");
            }

            return View(review);
        }
    }
}
