using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWeb.Models
{
    public class MapDAO : IMapDAO
    {
        public string GetGymsByLocation(string x, string y)
        {
            //1. x,y 사이의 체육관들을 DB에서 가져온다.
            //2. 해당 정보를 List형태로 만든다.
            //3. JSON Convert를 이용하여 json string으로 만든다.
            return "[{\"x\":\"126.973473\",\"y\":\"37.554780\",\"place_name\":\"남대문 경찰서\",\"addr\":\"서울특별시 중구 남대문로5가 한강대로 410\"}," +
                "{\"x\":\"126.973407\",\"y\":\"37.555210\",\"place_name\":\"건강보험공단\",\"addr\":\"서울특별시 중구 남대문로5가 541\"}]";
        }

    }
}