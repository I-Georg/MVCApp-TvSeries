using MVCApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLibrary;
using static DataLibrary.BusinessLogic.TvProcessor;

namespace MVCApp.Controllers
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
        public ActionResult SignUp()
        {
            ViewBag.Message = "User sign up";

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(UserModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = CreateUsers(model.Username, model.Email, model.Password
                                                    );
                return RedirectToAction("Index");
            }

            return View();
        }


        public ActionResult ViewTvSeries()
        {
            ViewBag.Message = "TvSeries List";

            var data = LoadTvSeries();
            List<TvModel> series = new List<TvModel>();

            foreach (var row in data)
            {
                series.Add(new TvModel
                {
                    TvSeriesID = row.TvSeriesID,
                    Title = row.Title,
                    Genre = row.Genre,
                    Rating = row.Rating,
                    Price = row.Price
                    
                });
            }

            return View(series);
        }

        public ActionResult AddSeries()
        {
            ViewBag.Message = "Add tv series";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddSeries(TvModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = CreateTvSeries(model.TvSeriesID,model.Title,model.ChannelOrigin,model.Genre,model.Rating,model.Price
                                                    );
                return RedirectToAction("Index");
            }

            return View();
        }

       
    }
}