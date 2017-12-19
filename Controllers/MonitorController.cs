using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Devices.Client;
using Microsoft.Azure.Devices.Client.Transport.Mqtt;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text;
using System.Threading.Tasks;

namespace restmodule.Controllers
{
    [Route("api/[controller]")]
    public class MonitorController : Controller
    {
        public MonitorController()
        {
        }

        [HttpGet("/queues")]
        public JObject Test()
        {
            var a = new { test = "123", name = "321" };
            return JObject.FromObject(a);
        }
    }
}
