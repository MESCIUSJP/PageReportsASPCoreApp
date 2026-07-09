using System;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace PageReportsASPCoreApp
{
    [Route("/")]
    public class HomeController : Controller
    {
        public object Index() => View("Index");
    }
}
