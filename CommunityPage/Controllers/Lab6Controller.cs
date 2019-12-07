using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;



namespace CommunityPage.Controllers
{
    public class Lab6Controller : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ContentResult TextTest()
        {
            return Content("This should Return this phrase as Content");
        }
        public RedirectResult RedirectTest()
        {
            return Redirect("https://www.google.com");
        }
        public EmptyResult EmptyData()
        {
            return new EmptyResult();
        }

        public IActionResult ClickBait()
        {
            return RedirectToPage("EmptyData");
        }
        
    }
}