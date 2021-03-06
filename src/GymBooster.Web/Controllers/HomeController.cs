﻿using System.Web.Mvc;
using GymBooster.Core;

namespace GymBooster.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var trainingRepo = new TrainingRepository();
            var trainings = trainingRepo.GetAllTrainings();
            return View(trainings);
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
    }
}