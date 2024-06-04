using HTMLHelperDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HTMLHelperDemo.Controllers
{
    public class ValidateController : Controller
    {
        // GET: Validate
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(Member member)
        {
            if (!ModelState.IsValid)
            {
                return View(member);
            }
            else
            {
                TempData["Member"] = member;
                return RedirectToAction("Result");
            }
        }

        public ActionResult Result()
        {
            var model = TempData["Member"] as Member;
            return View(model); 
        }

    }
}