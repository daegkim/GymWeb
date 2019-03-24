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
            Debug.WriteLine(x + y);
            return "[{\"x\":\"126.973473\",\"y\":\"37.554780\",\"place_name\":\"남대문 경찰서\",\"addr\":\"서울특별시 중구 남대문로5가 한강대로 410\"}," +
                "{\"x\":\"126.973407\",\"y\":\"37.555210\",\"place_name\":\"건강보험공단\",\"addr\":\"서울특별시 중구 남대문로5가 541\"}]";
        }
    }
}