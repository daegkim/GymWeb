using MyWeb.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWeb.Controllers
{
    public class MapController : Controller
    {
        public string GetGyms(string x, string y)
        {
            return new MapDAO().GetGymsByLocation(x, y);
        }
    }
}