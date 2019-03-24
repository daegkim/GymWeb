using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWeb.Models
{
    interface IMapDAO
    {
        //(x, y) 주변의 체육관들을 찾은 뒤에
        //각 체육관들의 정보들을 가진 List<GymViewModel>을 JSON형식의 string으로 만든다.
        string GetGymsByLocation(string x, string y);
    }
}
