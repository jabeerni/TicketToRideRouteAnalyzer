using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using RouteAnalyzer;

namespace TicketToRideAnalyzer.Models
{
    public class RouteViewModel
    {
        public string StartCity { get; set; }
        public string EndCity { get; set; }

        public List<City> StartCities { get; set; }
        public List<City> EndCities { get; set; }

        public List<Segment> RouteCities { get; set; }
        public int routeCost { get; set; }

        public IEnumerable<SelectListItem> StartingCities
        {
            get { return StartCities.Select(c => new SelectListItem { Value = c.ToString(), Text = c.ToString() }); }
        }

        public IEnumerable<SelectListItem> EndingCities
        {
            get { return EndCities.Select(c => new SelectListItem { Value = c.ToString(), Text = c.ToString() }); }
        }

    }
}