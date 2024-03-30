using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLM_24032024.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            throw new Exception("Custome errror");
            return "Hello from home controller.";
        }
    }
}
