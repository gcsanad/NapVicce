using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;

namespace nepVicce.Controllers
{
    public class NapVicceController : Controller
    {
        Dictionary<string, string> viccz = new Dictionary<string, string>() {

        {"Monday", "funny" },
        {"Tuesday", "xd" },
        {"Wednesday", "funny" },
        {"Thursday", "funny" },
        {"Friday", "funny" },
        {"Saturday", "funny" },
        {"Sunday", "funny" }
            
        };
        [HttpGet]
        [Route("[controller]")]
        
        public string Get()
        {
            //List<string> viccz = new() {"funny", "xd", "na uh", "viccike", "nagyon vicces", "joke", "mark hamil" };
            return $"{viccz.Where(x => x.Key == DateTime.Now.DayOfWeek.ToString()).First().Key} : {viccz.Where(x => x.Key == DateTime.Now.DayOfWeek.ToString()).First().Value}" ;
        }
    }
}
