using Microsoft.Web.Helpers;
using RouteAnalyzer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketToRideAnalyzer.Models;

namespace TicketToRideAnalyzer.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Message = "Ticket To Ride Route Analyzer.";

            var model = new RouteViewModel();
            model.StartCities = Enum.GetValues(typeof(City)).Cast<City>().ToList();
            model.EndCities = Enum.GetValues(typeof(City)).Cast<City>().ToList();
            model.RouteCities = new List<Segment>();

            model.MapHtml = Maps.GetBingHtml(key: "AjK_c-a0hYILuxmGiLjmJkossrnxKovOyzS6Q1tRu6R-T-ikma9tvJmkL5Vn5OJD", location: "2033 6th Ave, Seattle, WA", width: "600px", height: "800px")
                                .ToString()
                                .Replace("<text>", "")
                                .Replace("</text>", "")
                                .Replace("if (useAdaptiveOverlay) {", "")
                                .Replace("callback: function () {", "callback: function () { if (typeof(useAdaptiveOverlay) != '') { ")
                                .Replace("load(function() {", "load(function() { {");

            return View(model);
        }

        [HttpPost]
        public ActionResult Index(RouteViewModel model)
        {
            ViewBag.Message = "Ticket To Ride Route Analyzer.";
            model.StartCities = Enum.GetValues(typeof(City)).Cast<City>().ToList();
            model.EndCities = Enum.GetValues(typeof(City)).Cast<City>().ToList();
            model.RouteCities = new List<Segment>();

            model.MapHtml = Maps.GetBingHtml(key: "AjK_c-a0hYILuxmGiLjmJkossrnxKovOyzS6Q1tRu6R-T-ikma9tvJmkL5Vn5OJD", location: "North America", width: "600px", height: "800px")
                    .ToString()
                    .Replace("<text>", "")
                    .Replace("</text>", "")
                    .Replace("if (useAdaptiveOverlay) {", "")
                    .Replace("callback: function () {", "callback: function () { if (typeof(useAdaptiveOverlay) != '') { ")
                    .Replace("load(function() {", "load(function() { {");

            if (!string.IsNullOrWhiteSpace(model.StartCity) && !string.IsNullOrWhiteSpace(model.EndCity))
            {
                var pathManager = new PathManager();
                var startCity = (City)Enum.Parse(typeof(City), model.StartCity);
                var endCity = (City)Enum.Parse(typeof(City), model.EndCity);
                var route = pathManager.GetRoute(startCity, endCity);

                if (route.Any())
                {
                    foreach (var r in route)
                    {
                        model.RouteCities.Add(r);
                    }

                    model.routeCost = pathManager.BestCost;
                }
            }

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Play with various scenarios in the board game Ticket To Ride to see what's possible.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact Us.";

            return View();
        }
    }
}
