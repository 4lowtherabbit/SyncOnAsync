using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace SyncOnAsync.Controllers
{
    public class ReproController : Controller
    {
        private async Task<HttpResponseMessage> GetAsync()
        {
            HttpClient c = new HttpClient();
            return await c.GetAsync("http://juzhudelay.azurewebsites.net/Delay?seconds=10");
        }
        public string Index()
        {
            var response = GetAsync().Result;
            return "Done Test";
        }
    }
}