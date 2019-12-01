using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CommunityPage.Models;

namespace CommunityPage.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult History()
        {
            return View();
        }

        public ViewResult Info()
        {
            return View();
        }
        public ViewResult Important()
        {
            return View();
        }
        public ViewResult People()
        {
            return View();
        }
        public ViewResult Thanks()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        [HttpGet]
        public ViewResult Contact()
        {
            return View();
        }
        [HttpPost]
        public ViewResult Contact(ContactInfo contactinfo)
        {
                Repository.AddResponse(contactinfo);
                return View("Thanks",contactinfo);
        }
        public ViewResult Messages()
        {
            return View(Repository.Responses);
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
