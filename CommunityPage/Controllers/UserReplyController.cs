using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommunityPage.Models;
using Microsoft.AspNetCore.Mvc;

namespace CommunityPage.Controllers
{
    public class UserReplyController : Controller
    {
        [HttpGet]
        public ViewResult Replys()
        {
            ViewBag.Message = "All Replys are Reviewed";
            return View();
        }
        [HttpPost]
        public ViewResult Replys(ContactInfo reply)
        {
            List<MessageBoards> boards = reply.ToList();
            reply.Sort((c1, c2) => string.Compare(c1.ToString(), c2.ToString(), StringComparison.Ordinal));
            return View(boards);

        }
    }
}